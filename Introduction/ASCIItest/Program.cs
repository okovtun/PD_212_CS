#define FIGURE
//#define SHUTER

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuter_and_Figure
{
	internal class Program
	{
		const string delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
#if FIGURE
			Console.Write("Введите размер фигур: ");
			int n = Convert.ToInt32(Console.ReadLine());

			for (int i = n; i > 0; i--)
			{
				for (int j = n; j > 0; j--) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);


			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j <= i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n - i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			for (int i = 0; i < n; i++)
			{
				for (int space = 0; space < i; space++) Console.Write(" ");
				for (int j = 0; j < n - i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);


			for (int i = 0; i < n; i++)
			{
				for (int space = 0; space < n - i - 1; space++) Console.Write(" ");
				for (int j = 0; j <= i; j++) Console.Write("*");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);


			for (int i = 0; i < n; i++)
			{
				for (int space = 0; space < n - i - 1; space++) Console.Write(" ");
				Console.Write("/");
				for (int j = 0; j < i; j++) Console.Write("  ");
				Console.Write("\\");
				Console.WriteLine();
			}
			for (int i = 0; i < n; i++)
			{
				for (int space = 0; space < i; space++) Console.Write(" ");
				Console.Write("\\");
				for (int j = 0; j < n - i - 1; j++) Console.Write("  ");
				Console.Write("/");
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((i + j) % 2 == 0) Console.Write("+");
					else Console.Write("-");
				}
				Console.WriteLine();
			}
			Console.WriteLine(delimiter);

			//setlocale(LC_ALL, ".866");
			// var toEncoding = Encoding.GetEncoding(".886");
			// Encoding win = Encoding.GetEncoding("CP-886");



			Console.WriteLine(Console.OutputEncoding.BodyName);
			Console.WriteLine(Console.OutputEncoding.CodePage);
			Console.WriteLine(Console.OutputEncoding.WindowsCodePage);
			Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
			Console.WriteLine(Console.OutputEncoding.CodePage);

			for (int i = 0; i < 256; i++)
			{
				if (i % 16 == 0) Console.WriteLine();
				Console.Write((char)i + " ");
			}

			char ugol_left_up = Convert.ToChar(218);
			char ugol_left_down = Convert.ToChar(219);
			char white = Convert.ToChar(166);//некорректно
			char gorizont = Convert.ToChar(196);
			char ugol_right_up = Convert.ToChar(191);
			char ugol_right_down = Convert.ToChar(217);
			char vertical = Convert.ToChar(179);
			Console.WriteLine();
			Console.Write("\t");
			Console.Write(ugol_left_up);
			for (int i = 0; i < n * 2; i++) Console.Write(gorizont);
			Console.WriteLine(ugol_right_up);
			for (int i = 0; i < n; i++)
			{
				int y = 0;
				y++;
				Console.Write("\t");
				Console.Write(vertical);
				for (int j = 0; j < n * 3; j = j + 3)
				{
					if ((i + j) % 2 == 0)
					{
						Console.Write(white);
						Console.Write(white);
					}
					else Console.Write("  ");
				}
				Console.WriteLine(vertical);
			}
			Console.Write("\t");
			Console.Write(ugol_left_down);
			for (int i = 0; i < n * 2; i++) Console.Write(gorizont);
			Console.Write(ugol_right_down);

			Console.WriteLine(delimiter);


			for (int i = 0; i < n; i++)
			{
				if (i % 2 == 0)
				{
					for (int j = 0; j < n; j++)
					{
						for (int l = 0; l < n; l++)
						{
							if (l % 2 == 0)
								for (int m = 0; m < n; m++) Console.Write("* ");
							else
								for (int m = 0; m < n; m++) Console.Write("  ");
						}
						Console.WriteLine();
					}
				}
				else
				{
					for (int j = 0; j < n; j++)
					{
						for (int l = 0; l < n; l++)
						{
							if (l % 2 != 0)
								for (int m = 0; m < n; m++) Console.Write("* ");
							else
								for (int m = 0; m < n; m++) Console.Write("  ");
						}
						Console.WriteLine();
					}
				}
			}
#endif

#if SHUTER
            //char play;
            ConsoleKey play;
            do
            {
                //play = Console.ReadKey(true).KeyChar;
                play = Console.ReadKey(true).Key;
                // if (play == 13)
                // cout << "Îãîíü" << endl;
                //switch (play)
                //{
                //    case 'w':
                //    case 'W': Console.WriteLine("Вперед") ; break;
                //    case 's':
                //    case 'S': Console.WriteLine("Назад"); break;
                //    case 'd':
                //    case 'D': Console.WriteLine("Вправо"); break;
                //    case 'a':
                //    case 'A': Console.WriteLine("Влево"); break;
                //    case ' ': Console.WriteLine("Прыжок"); break;
                //    default:
                //        Console.WriteLine("Error"); break;
                //}
                switch (play)
                {
                    case ConsoleKey.W: Console.WriteLine("Вперед"); break;
                    case ConsoleKey.S: Console.WriteLine("Назад"); break;
                    case ConsoleKey.A: Console.WriteLine("Вправо"); break;
                    case ConsoleKey.D: Console.WriteLine("Влево"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Прыжок"); break;
                    default:
                        Console.WriteLine("Error"); break;
                }
            } while (Convert.ToChar(play) != 27);
#endif
		}

		//private static char _getch()
		//      {
		//          throw new NotImplementedException();
		//      }

	}
}
