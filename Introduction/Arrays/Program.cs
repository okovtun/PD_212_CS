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
			FillRand(arr);
			Print(arr);

			//Range-based for
			//foreach
			foreach (int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();
			Console.WriteLine(arr.Rank);

			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");

			double[] d_arr = new double[n];
			FillRand(d_arr);
			Print(d_arr);
			Console.WriteLine($"Сумма элементов массива: {d_arr.Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {d_arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {d_arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {d_arr.Max()}");

			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////////////

			Console.Write("Введите количество строк: ");
			int rows = Convert.ToInt32(Console.ReadLine());
			Console.Write("Введите количество элементов строки: ");
			int cols = Convert.ToInt32(Console.ReadLine());
			int[,] i_arr_2 = new int[rows, cols];
			FillRand(i_arr_2);
			Print(i_arr_2);
			Console.WriteLine(i_arr_2.Rank);
			Console.WriteLine(i_arr_2.GetLength(0));
			Console.WriteLine(i_arr_2.GetLength(1));
			foreach (int i in i_arr_2)
			{
				Console.Write(i+"\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");
			Console.WriteLine($"Среднее-арифметическое элементов массива: {i_arr_2.Cast<int>().Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {i_arr_2.Cast<int>().Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {i_arr_2.Cast<int>().Max()}");
			Console.WriteLine(delimiter);

			////////////////////////////////////////////////////////////////////////////////////

			int[][] jagged_arr = new int[][]
				{
					new int[]{ 3, 5, 8, 13, 21},
					new int[]{ 34, 55, 89},
					new int[]{ 144, 233, 377, 510},
					arr
				};
			Print(jagged_arr);
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {Sum(jagged_arr)}");
			Console.WriteLine($"Количество элементов массива: {Count(jagged_arr)}");
			//Console.WriteLine($"Среднее-арифметическое элементов массива: {jagged_arr.Cast<int>().Average()}");
			//Console.WriteLine($"Минимальное значение в массиве: {jagged_arr.Cast<int>().Min()}");
			//Console.WriteLine($"Максимальное значение в массиве: {jagged_arr.Cast<int>().Max()}");
			Console.WriteLine(delimiter);

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
		public static void FillRand(int[] arr)
		{
			Random rand = new Random(0);    //Создаем объект класса 'Random' для того чтобы генерировать случайные числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100, 200);
			}
		}
		public static void FillRand(double[] arr)
		{
			Random rand = new Random(0);    //Создаем объект класса 'Random' для того чтобы генерировать случайные числа
			for (int i = 0; i < arr.Length; i++)
			{
				arr[i] = (double)rand.Next(100, 200)/10;
			}
		}
		public static void FillRand(int[,] arr)
		{
			Random rand = new Random(0);
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					arr[i, j] = rand.Next(100);
				}
			}
		}
		

		public static void Print<T>(T[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
		}
		public static void Print<T>(T[,] arr)
		{
			for (int i = 0; i < arr.GetLength(0); i++)
			{
				for (int j = 0; j < arr.GetLength(1); j++)
				{
					Console.Write(arr[i, j] + "\t");
				}
				Console.WriteLine();
			}
		}
		public static void Print<T>(T[][] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				for (int j = 0; j < arr[i].Length; j++)
				{
					Console.Write(arr[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}
		public static int Sum(int[][] arr)
		{
			int sum = 0;
			foreach (int[] i in arr)
			{
				sum += i.Sum();
			}
			return sum;
		}
		public static int Count(int[][] arr)
		{
			int count = 0;
			foreach (int[] i in arr) count += i.Count();
			return count;
		}
	}
}
