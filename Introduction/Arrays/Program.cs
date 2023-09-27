using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	class Program
	{
		static readonly string delimiter = "\n-------------------------------------------------------\n";
		static void Main(string[] args)
		{
			Console.Write("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			int[] arr = new int[n];
			Random rand = new Random(0);    //Создаем объект класса 'Random' для того чтобы генерировать случайные числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100, 200);
			}

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();

			//Range-based for
			//foreach
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine(arr.Rank);
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////////////

			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			int[,] i_arr_2 = new int[rows, cols];
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					i_arr_2[i, j] = rand.Next(100);
				}
			}
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine(i_arr_2.Rank);
			Console.WriteLine(i_arr_2.GetLength(0));
			Console.WriteLine(i_arr_2.GetLength(1));
			foreach (int i in i_arr_2)
			{
				Console.Write(i+"\t");
			}
			Console.WriteLine();
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////////////

			int[][] jagged_arr = new int[][]
				{
					new int[]{ 3, 5, 8, 13, 21},
					new int[]{ 34, 55, 89},
					new int[]{ 144, 233, 377, 510},
					arr
				};
			for (int i = 0; i < jagged_arr.Length; i++)
			{
				for (int j = 0; j < jagged_arr[i].Length; j++)
				{
					Console.Write(jagged_arr[i][j] + "\t");
				}
				Console.WriteLine();
			}

			int[][,] jagged_arr_2 = new int[][,]
				{
					i_arr_2,
					new int[,]
					{
						{ 256, 384, 512, 768},
						{ 1024, 2048, 3072, 4096}
					}
				};
		}
	}
}
