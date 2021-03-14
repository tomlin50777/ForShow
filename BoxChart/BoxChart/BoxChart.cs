using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace BoxChartProject
{
	public class BoxChart : Chart
	{
		private ChartArea chartArea;
		private Legend legend;
		private Series series;
		public BoxChart(Color color, double max, double min)
		{
			chartArea = new ChartArea();
			legend = new Legend();
			series = new Series();
			this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
| System.Windows.Forms.AnchorStyles.Left)
| System.Windows.Forms.AnchorStyles.Right)));
			chartArea.Name = "ChartArea";
			this.ChartAreas.Add(chartArea);
			this.Cursor = System.Windows.Forms.Cursors.Cross;
			legend.Name = "Legend";
			this.Legends.Add(legend);
			this.Location = new System.Drawing.Point(3, 3);
			this.Name = "chart";
			this.Size = new System.Drawing.Size(750, 197);
			this.TabIndex = 0;
			this.Text = "chart";
			chartArea.AxisY.Maximum = max;
			chartArea.AxisY.Minimum = min;
			series.ChartArea = "ChartArea";
			series.ChartType = SeriesChartType.BoxPlot;
			series.Legend = "Legend";
			series.Name = "Series";
			series.YValuesPerPoint = 6;
			series.XValueType = ChartValueType.Date;
			series.IsVisibleInLegend = false;
			series.Color = color;
			this.Series.Add(series);
		}
		///好單純的加點
		public void AddPoints(DateTime dateTime, double max, double min, double firstQuartile, double thirdQuartile, double average, double median)
		{
			series.Points.AddXY(dateTime, min, max, firstQuartile, thirdQuartile, median, average);
			chartArea.AxisX.Maximum = series.Points[series.Points.Count - 1].XValue;
			chartArea.AxisX.Minimum = series.Points[0].XValue;
		}
		//用於控制只讓最左邊那個Chart有Y Axis
		public void YAxisVisible(bool isVisible)
		{
			if (isVisible)
				chartArea.AxisY.Enabled = AxisEnabled.True;
			else
				chartArea.AxisY.Enabled = AxisEnabled.False;
		}
	}
}
