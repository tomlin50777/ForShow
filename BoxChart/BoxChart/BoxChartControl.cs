using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BoxChartProject
{
	public partial class BoxChartControl : UserControl
	{
		private List<BoxChart> boxCharts;
		private List<TableLayoutPanel> tableLayoutPanels;
		public BoxChartControl()
		{
			InitializeComponent();
			boxCharts = new List<BoxChart>();
			tableLayoutPanels = new List<TableLayoutPanel>();
		}
		/// <summary>
		/// 資入資料的，以一天為一個盒子畫
		/// </summary>
		/// <param name="dataTable">資料</param>
		/// <param name="xAxisColumnName">時間欄位名稱</param>
		/// <param name="valueColumnName">數值欄位名稱</param>
		/// <param name="color">盒子的顏色</param>
		/// <param name="yMax">Y軸最大值</param>
		/// <param name="yMin">Y軸最小值</param>
		/// <param name="fix">修正值，用來壓縮沒有Axis圖的高度</param>
		public void AddData(DataTable dataTable, String xAxisColumnName, String valueColumnName, Color color, double yMax, double yMin, Single fix)
		{
			DateTime startDate;
			DateTime endDate;
			DateTime.TryParse(((String)dataTable.Rows[0][xAxisColumnName]).Substring(0, 10), out startDate);
			DateTime.TryParse(((String)dataTable.Rows[dataTable.Rows.Count - 1][xAxisColumnName]).Substring(0, 10), out endDate);
			int dateCount = 0;
			int.TryParse((endDate.AddDays(1) - startDate).TotalDays + "", out dateCount);
			BoxChart newBoxChart = AddItem(color, yMin, yMax, fix);
			for (int count = 0; count < dateCount; count++)
			{
				dataTable.CaseSensitive = false;
				double[] value = GetValueFormDataTable(dataTable.Select(xAxisColumnName + " like '" + startDate.ToString("yyyy/MM/dd") + "%'").CopyToDataTable(), valueColumnName);
				Array.Sort(value);
				newBoxChart.AddPoints(startDate, value.Max(), value.Min(), value[value.Length / 4], value[value.Length * 3 / 4], value.Average(), value[value.Length / 2]);
				startDate = startDate.AddDays(1);
			}

		}
		/// <summary>
		/// 把數值變double用的，用你原本linQ的方法就不用這步
		/// </summary>
		/// <param name="dataTable">資料</param>
		/// <param name="valueColumnName">Value欄位名稱</param>
		/// <returns></returns>
		private double[] GetValueFormDataTable(DataTable dataTable, String valueColumnName)
		{
			double[] result = new double[dataTable.Rows.Count];
			for (int count = 0; count < result.Length; count++)
			{
				Double.TryParse(dataTable.Rows[count][valueColumnName] + "", out result[count]);
			}
			return result;
		}
		/// <summary>
		/// 加一個新圖，用在不同Tag上，會一朝有放入的數量做版面控制
		/// </summary>
		/// <param name="color"></param>
		/// <returns></returns>
		private BoxChart AddItem(Color color, double max, double min, Single fix)
		{
			BoxChart boxChart = new BoxChart(color, max, min);
			TableLayoutPanel tableLayoutPanel = NewTableLayoutPanel(fix);
			boxChart.YAxisVisible(boxCharts.Count == 0);
			boxCharts.Add(boxChart);
			tableLayoutPanels.Add(tableLayoutPanel);
			this.chartTableLayoutPanel.Controls.Clear();
			chartTableLayoutPanel.ColumnCount = boxCharts.Count;
			chartTableLayoutPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)| AnchorStyles.Left)| AnchorStyles.Right)));
			Single blockWidth = 100F / boxCharts.Count;
			chartTableLayoutPanel.ColumnStyles.Clear();
			for (int count = 0; count < chartTableLayoutPanel.ColumnCount; count++)
			{
					chartTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, blockWidth));
			}
			chartTableLayoutPanel.Location = new Point(12, 12);
			this.chartTableLayoutPanel.RowCount = 1;
			this.chartTableLayoutPanel.RowStyles.Clear();
			this.chartTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
			for (int count = 0; count < boxCharts.Count; count++)
			{
				this.chartTableLayoutPanel.Controls.Add(tableLayoutPanels[count], count, 0);
				tableLayoutPanels[count].Controls.Add(boxCharts[count], 0, 1);
			}
			return boxChart;
		}
		private TableLayoutPanel NewTableLayoutPanel(Single fix)
		{
			TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
			tableLayoutPanel.ColumnCount = 1;
			tableLayoutPanel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left) | AnchorStyles.Right)));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel.RowCount = 3;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, fix));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F - fix));
			return tableLayoutPanel;
		}
	}
}
