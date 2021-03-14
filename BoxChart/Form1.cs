using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoxChartProject
{
	public partial class Form1 : Form
	{
		private DataTable fakeData;
		private List<Color> colors;
		public Form1()
		{
			InitializeComponent();
			fakeData = new DataTable();
			colors = new List<Color>();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//製作Fake data用的參數
			int tagNumber = 8;
			int dateNmber = 4;
			int valuenumber = 400;
			RandonFakeData(tagNumber, dateNmber, valuenumber);
			for (int count = 0; count < tagNumber; count++)
			{
				if(count ==0)
					boxChartControl1.AddData(fakeData.Select("tagName = 'Tag_" + count + "'").CopyToDataTable(), "date", "value", colors[count], -2, 3100, 0.5F, 0F);
				else
					boxChartControl1.AddData(fakeData.Select("tagName = 'Tag_" + count + "'").CopyToDataTable(), "date", "value", colors[count], -2, 3100, 0.5F, 2F);
			}
		}
		/// <summary>
		/// Faks Data製作用，
		/// </summary>
		/// <param name="tagNumner">有幾個tag</param>
		/// <param name="dateNumber">有幾天資料</param>
		/// <param name="valueNumberPerDate">每天有幾筆資料</param>
		private void RandonFakeData(int tagNumner, int dateNumber, int valueNumberPerDate)
		{
			Random random = new Random();
			fakeData.Columns.Add("tagName", typeof(String));
			fakeData.Columns.Add("date", typeof(String));
			fakeData.Columns.Add("value", typeof(String));

			for (int countTag = 0; countTag < tagNumner; countTag++)
			{
				colors.Add(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
				DateTime dateTime = DateTime.Now;
				for (int countDate = 0; countDate < dateNumber; countDate++)
				{
					for (int countValue = 0; countValue < valueNumberPerDate; countValue++)
					{
						DataRow row = fakeData.NewRow();
						row["tagName"] = "Tag_" + countTag;
						row["date"] = dateTime.ToString("yyyy/MM/dd HH:mm:ss");
						row["value"] = (random.NextDouble() * 3000) + "";
						fakeData.Rows.Add(row);
					}
					dateTime = dateTime.AddDays(1);
				}
			}
		}
	}
}
