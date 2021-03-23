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
	public partial class ValueUserControl : UserControl
	{
		public ValueUserControl()
		{
			InitializeComponent();
		}
		public void SetTitle(String title)
		{
			titleLabel.Text = title;
		}
		public void SetLabel(String leftLabel, String rightLabel)
		{
			lineWidthLabel.Text = leftLabel;
			pixelLabel.Text = rightLabel;
		}
		public void SetInit(int width)
		{
			lineWidthTextBox.Text = width + "";
		}
		public int GetValue()
		{
			int lineWidth;
			if (int.TryParse(lineWidthTextBox.Text, out lineWidth))
			{
				return lineWidth;
			}
			return -1;
		}
	}
}
