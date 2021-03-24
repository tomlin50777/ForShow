using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace FAMLineCreater
{
	public class FamLineCreaterTool
	{
		private Bitmap bitmap;
		private Dictionary<int, int> line;
		private Color judgeColor;
		private Color mappingColor;
		private Color endColor;
		private int offset;
		private int upLineY;
		private int downLineY;
		private int rangeUpLineY;
		private int rangeDownLineY;
		private List<int> lineX;
		private int judgeLineWidth;
		private int mappingLineWidth;
		private DashStyle dashStyle;
		public FamLineCreaterTool()
		{
			lineX = new List<int>();
		}
		public Bitmap FamDraw(Bitmap bitmap, Dictionary<int, int> line, Color judgeColor, int judgeLineWidth, Color mappingColor, int mappingLineWidth, Color endColor, int offset, DashStyle dashStyle)
		{
			SetData(bitmap, line, judgeColor, judgeLineWidth, mappingColor, mappingLineWidth, endColor, offset, dashStyle);
			Positioning();
			Clear();
			DrawFam();
			return bitmap;
		}
		
		private void SetData(Bitmap bitmap, Dictionary<int, int> line, Color judgeColor, int judgeLineWidth, Color mappingColor, int mappingLineWidth, Color endColor, int offset, DashStyle dashStyle)
		{
			this.bitmap = bitmap;
			this.line = line;
			this.judgeColor = judgeColor;
			this.mappingColor = mappingColor;
			this.endColor = endColor;
			this.offset = offset;
			this.judgeLineWidth = judgeLineWidth;
			this.mappingLineWidth = mappingLineWidth;
			this.dashStyle = dashStyle;
			upLineY = -1;
			downLineY = -1;
			rangeUpLineY = -1;
			rangeDownLineY = -1;
			lineX.Clear();
			GC.Collect();
		}
		private void Positioning()
		{
			int judgeX = 0;
			bool isRangeUp = false;
			for (int countX = 0; countX < bitmap.Width; countX++)
				if (bitmap.GetPixel(countX, offset) == judgeColor)
					lineX.Add(countX + (judgeLineWidth - 1) / 2);
			foreach (int start in line.Keys)
			{
				if (line[start] > start)
				{
					judgeX = lineX[start] + 1;
					break;
				}
			}
			for (int countY = 0; countY < bitmap.Height; countY++)
			{
	
				if (bitmap.GetPixel(judgeX, countY) == judgeColor && upLineY == -1)
				{
					upLineY = countY;
				}
				else if (bitmap.GetPixel(judgeX, countY) == judgeColor)
				{
					downLineY = countY;
				}
				if (bitmap.GetPixel(judgeX, countY) == endColor && upLineY == -1)
				{
					isRangeUp = true;
				}
				else if (bitmap.GetPixel(judgeX, countY) == endColor)
				{
					rangeDownLineY = countY - 1;
				}
				if (bitmap.GetPixel(judgeX, countY) != endColor && isRangeUp)
				{
					rangeUpLineY = countY;
					isRangeUp = false;
				}
				if (upLineY != -1 && downLineY != -1 && rangeUpLineY != -1 && rangeDownLineY != -1)
					break;
			}
		}
		private void Clear()
		{
			for (int countY = 0; countY < bitmap.Height; countY++)
			{
				if (countY == upLineY || countY == downLineY)
				{
					for (int countX = 0; countX < bitmap.Width; countX++)
						if (bitmap.GetPixel(countX, countY) == judgeColor)
							bitmap.SetPixel(countX, countY, GetMaxColor(countX, countY));
				}
				else
				{
					for (int countX = 0; countX < lineX.Count; countX++)
						if (bitmap.GetPixel(lineX[countX], countY) == judgeColor)
							bitmap.SetPixel(lineX[countX], countY, bitmap.GetPixel(lineX[countX] - 1, countY));
				}
			}
		}
		private Color GetMaxColor(int countX, int countY)
		{
			Color clearColor = Color.FromArgb(0, 0, 0);
			Dictionary<Color, int> colorCount = new Dictionary<Color, int>();
			int xStart = lineX[0] - 25;
			int max = -999999;
			if (xStart < 0)
				xStart = 0;
			for (int countYOffset = -2; countYOffset < 3; countYOffset++)
			{
				for (int countXOffset = -2; countXOffset < 5; countXOffset++)
				{
					Color temp = bitmap.GetPixel(countX + countXOffset, countY + countYOffset);
					if (colorCount.ContainsKey(temp))
						colorCount[temp]++;
					else
						colorCount.Add(temp, 1);
					if (colorCount[temp] > max)
					{
						clearColor = temp;
						max = colorCount[temp];
					}
				}
			}
			return clearColor;
		}
		private void DrawFam()
		{
			int level = 0;
			Pen pen = new Pen(mappingColor, mappingLineWidth);
			Graphics graphics = Graphics.FromImage(bitmap);
			pen.DashStyle = dashStyle;
			int[] keys = line.Keys.ToArray();
			for(int count = 0; count < keys.Length; count++)
			{
				if (keys[count] == -1)
					continue;
				if (line[keys[count]] == -2)
				{
					level--;
					continue;
				}

				if (line[keys[count]] == -1)
				{
					graphics.DrawLine(pen, lineX[keys[count]], rangeUpLineY, lineX[keys[count]], rangeDownLineY);
				}
				else
				{
					int offset = 0;
					if (int.TryParse(Math.Round((downLineY - upLineY) * 0.02, 0) + "", out offset))
					{
						graphics.DrawRectangle(pen, lineX[keys[count]], upLineY + offset * level, lineX[line[keys[count]]] - lineX[keys[count]], downLineY - upLineY - 2 * offset * level);
						line[line[keys[count]]] = -2;
						level++;
					}
				}
			}
			pen.Dispose();
			graphics.Dispose();
			GC.Collect();
		}
	}
}
