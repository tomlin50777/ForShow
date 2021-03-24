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
	public partial class TestForm : Form
	{
		public TestForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Bitmap qq = new Bitmap("D:\\QQ.bmp");
			pictureBox1.Image = new Bitmap(qq, pictureBox1.Size);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Dictionary<int, int> line = new Dictionary<int, int>();
			line.Add(-1, -1);
			line.Add(0, -1);
			line.Add(1, 3);
			line.Add(2, 4);
			line.Add(3, 1);
			line.Add(4, 2);
			line.Add(5, -1);
			line.Add(6, 7);
			line.Add(7, 6);
			line.Add(8, 10);
			line.Add(9, -1);
			line.Add(10, 8);
			Bitmap qq = new Bitmap("D:\\QQ2.bmp");
			FamLineCreaterTool famLineCreaterTool = new FamLineCreaterTool();
			Bitmap gg = famLineCreaterTool.FamDraw(qq, line, Color.FromArgb(0, 1, 234), 1, Color.FromArgb(200, 44, 55), 3, Color.FromArgb(0, 0, 0), 80, System.Drawing.Drawing2D.DashStyle.Dash);
			pictureBox1.Image = new Bitmap(gg, pictureBox1.Size);
		}
	}
}
