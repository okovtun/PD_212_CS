using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoding
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Console.OutputEncoding.BodyName);
			Console.WriteLine(Console.OutputEncoding.CodePage);
			Console.WriteLine(Console.OutputEncoding.WindowsCodePage);
			Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
			//https://stackoverflow.com/questions/34328680/print-ascii-char-on-the-console-in-c-sharp
			//!!!	BUT:Console font have to be "Raster Fonts"	!!!
			int i = 0;
			for (; i < 256; i++)
			{
				if (i % 16 == 0) Console.WriteLine();
				Console.Write((char)i + " ");
			}
			Console.WriteLine();
		}
	}
}
