using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FAMLineCreater
{
	public partial class ColorSetUserControl : UserControl
	{
		public ColorSetUserControl()
		{
			InitializeComponent();
		}
		public void SetTitle(String title)
		{
			titleLabel.Text = title;
		}
		public void SetInitColor(int r, int g, int b)
		{
			rTextBox.Text = r + "";
			gTextBox.Text = g + "";
			bTextBox.Text = b + "";
		}
		public Color GetColor()
		{
			int r;
			int g;
			int b;
			if (int.TryParse(rTextBox.Text, out r) && int.TryParse(gTextBox.Text, out g) && int.TryParse(bTextBox.Text, out b))
			{
				return Color.FromArgb(r, g, b);
			}
			return Color.FromArgb(255, 255, 255);
		}
	}
}
