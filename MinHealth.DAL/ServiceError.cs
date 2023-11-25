using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinHealth.DAL
{
	public static class ServiceError
	{
		private static string path =
			Path.Combine(Directory.GetCurrentDirectory(),
				"Log");
		public static void WriteLog(Exception e)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			else
			{
				string filePath = Path.Combine(path,
					DateTime.Now.ToShortDateString() + "_log.txt");

				FileInfo file = new FileInfo(filePath);
				if (!file.Exists)
				{
					FileStream fs = file.Create();
					fs.Close();
				}
				using (StreamWriter sw = File.AppendText(filePath))
				{
					//1 Время, 2 откуда, 3 сообщение
					sw.WriteLine("-> {0}: {1} | {2}",
						DateTime.Now,
						e.Message,
						e.StackTrace);
				}
			}
		}
	}
}
