using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAMLineCreater
{
	public partial class FamTestForm : Form
	{
		Dictionary<int, int> line;
		public FamTestForm()
		{
			InitializeComponent();

			judgeColorSetUserControl.SetTitle("Judge Color");
			judgeColorSetUserControl.SetInitColor(0, 1, 234);
			mappingColorSetUserControl.SetTitle("Mapping Color");
			mappingColorSetUserControl.SetInitColor(128, 1, 234);
			endColorSetUserControl.SetTitle("End Color");
			endColorSetUserControl.SetInitColor(0, 0, 0);
			judgeValueUserControl.SetTitle("Judge");
			judgeValueUserControl.SetInit(1);
			mappingValueUserControl.SetTitle("Mapping");
			mappingValueUserControl.SetInit(3);
			offsetValueUserControl.SetTitle("Offset");
			offsetValueUserControl.SetInit(80);
			offsetValueUserControl.SetLabel("", "");
			foreach(System.Drawing.Drawing2D.DashStyle dashStyle in Enum.GetValues(typeof(System.Drawing.Drawing2D.DashStyle)).Cast<System.Drawing.Drawing2D.DashStyle>().ToArray())
				dashTypeListBox.Items.Add(dashStyle.ToString());
			dashTypeListBox.SelectedIndex = 2;
			richTextBox.Text = "0\n1,9\n2,10\n3,8\n4,7\n5,6\n6,5\n7,4\n8,3\n9,1\n10,2";
		}
		private void LineCreate()
		{
			String data = richTextBox.Text;
			String[] dataSplit = data.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
			line = new Dictionary<int, int>();
			line.Add(-1, -1);
			foreach (String temp in dataSplit)
			{
				String[] tempSplit = temp.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				int key = 0;
				int value = 0;
				if (tempSplit.Length == 1)
				{
					if (int.TryParse(tempSplit[0], out key))
						line.Add(key, -1);
				}
				else
				{
					if (int.TryParse(tempSplit[0], out key) && int.TryParse(tempSplit[1], out value))
						line.Add(key, value);
				}
			}
		}
		private void TestButton_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap(1500, 1100);
			Color color = judgeColorSetUserControl.GetColor();
			List<int> x = new List<int>();
			int offser = 50;
			int lineWidth = 3;
			LineCreate();
			for (int countY = 0; countY < bitmap.Height; countY++)
			{
				for (int countX = 0; countX < bitmap.Width; countX++)
					bitmap.SetPixel(countX, countY, Color.FromArgb(255, 255, 255));
			}
			for (int countY = offser; countY < bitmap.Height - offser - lineWidth; countY++)
			{
				for (int count = 0; count < lineWidth; count++)
				{
					bitmap.SetPixel(offser + count, countY, endColorSetUserControl.GetColor());
					bitmap.SetPixel(bitmap.Width - offser - count, countY, endColorSetUserControl.GetColor());
				}
			}
			for (int countX = offser; countX < bitmap.Width - offser - lineWidth; countX++)
			{
				for (int count = 0; count < lineWidth; count++)
				{
					bitmap.SetPixel(countX, offser + count, endColorSetUserControl.GetColor());
					bitmap.SetPixel(countX, bitmap.Height - offser - count, endColorSetUserControl.GetColor());
				}
			}

			for (int countY = offser + lineWidth + offser; countY < bitmap.Height - offser - offser - lineWidth; countY++)
			{
				Color[] colors = new Color[] { Color.Aqua, Color.Red, Color.Yellow, Color.Pink, Color.Green, Color.Brown, Color.DarkCyan, Color.Beige };
				int setColor = (bitmap.Width - lineWidth * 2 - offser * 2) / 8 + 1;
				for (int countX = offser + lineWidth; countX < bitmap.Width - offser - lineWidth; countX++)
				{
					bitmap.SetPixel(countX, countY, colors[(countX - offser - lineWidth) / setColor]);
				}
			}
			for (int countX = offser + lineWidth + 1; countX < bitmap.Width - offser - lineWidth - 1; countX++)
			{
				if (bitmap.GetPixel(countX, bitmap.Height / 2) != bitmap.GetPixel(countX + 1, bitmap.Height / 2))
				{
					for (int countY = offser + lineWidth; countY < bitmap.Height - offser - lineWidth; countY++)
						for(int count = 0; count < lineWidth; count++)
							bitmap.SetPixel(countX - 1 + count, countY, endColorSetUserControl.GetColor());
					countX += lineWidth - 1;
				}
			}
			for (int countY = offser + lineWidth; countY < bitmap.Height - offser - lineWidth; countY++)
			{
				int setColor = (bitmap.Width - lineWidth * 2 - offser * 2) / line.Count + 1;
				for (int countX = offser + lineWidth + setColor; countX < bitmap.Width - offser - lineWidth; countX+= setColor)
				{
					bitmap.SetPixel(countX, countY, color);
				}
			}
			for (int countX = offser + lineWidth + 1; countX < bitmap.Width - offser - lineWidth; countX++)
			{
				if (bitmap.GetPixel(countX, offser + lineWidth) == color)
					x.Add(countX);
			}
			foreach (int key in line.Keys)
				if(line[key] > key)
					for (int countX = x[key]; countX < x[line[key]]; countX++)
					{
						bitmap.SetPixel(countX, offser + lineWidth + offser + 20, color);
						bitmap.SetPixel(countX, bitmap.Height - offser - offser - lineWidth - 20, color);
						
					}
			pictureBox.Image = new Bitmap(bitmap, pictureBox.Size);
			bitmap.Save("QQ.bmp");
		}

		private void FamLineCreatorTestButton_Click(object sender, EventArgs e)
		{
			Bitmap bitmap = new Bitmap("QQ.bmp");
			FamLineCreaterTool famLineCreaterTool = new FamLineCreaterTool();
			bitmap = famLineCreaterTool.FamDraw(bitmap, line, judgeColorSetUserControl.GetColor(), judgeValueUserControl.GetValue(), mappingColorSetUserControl.GetColor(), mappingValueUserControl.GetValue(), endColorSetUserControl.GetColor(), offsetValueUserControl.GetValue(), (System.Drawing.Drawing2D.DashStyle)Enum.Parse(typeof(System.Drawing.Drawing2D.DashStyle), dashTypeListBox.SelectedItem.ToString(), true));
			pictureBox.Image = new Bitmap(bitmap, pictureBox.Size);
			bitmap.Save("DrawQQ.bmp");
			bitmap.Dispose();
		}

		private void judgeColorSetUserControl_Load(object sender, EventArgs e)
		{

		}
	}
}
