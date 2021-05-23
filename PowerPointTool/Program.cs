using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PowerPointTool
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime start = DateTime.Now;
			DateTime end;
			String path = @"E:\TestPPT\QQ.pptx";
			String newPath = Path.Combine(Path.GetDirectoryName(path), DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss__") + Path.GetFileName(path));
			PowerPointEdit ppe = new PowerPointEdit();
			ppe.OpenFile(path, newPath);
			ppe.SetText("1", "這是測試", 0);
			for (int count = 0; count < 500; count++)
			{
				ppe.CopyPage(1);
				ppe.SetText("111", "Text1_" + count);
				ppe.SetText("222", "Text2_" + count);
				ppe.SetText("333", "Text3_" + count);
				ppe.SetPhoto("Test", @"E:\TestPPT\" + ((count % 10) + 1) + ".png");
			}
			ppe.RemovePage(1);
			ppe.CloseFile();
			end = DateTime.Now;
			Console.WriteLine(new TimeSpan(end.Ticks - start.Ticks).TotalSeconds);
		}
	}
}
