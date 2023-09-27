using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите арифметическое выражение: ");
			string expression = Console.ReadLine();
			Console.WriteLine(expression);
			string[] operands = expression.Split('+', '-', '*', '/');
			//for (int i = 0; i < operands.Length; i++)
			//{
			//	Console.WriteLine(operands[i]);
			//}
			double a = Convert.ToDouble(operands[0]);
			double b = Convert.ToDouble(operands[1]);
			if (expression.Contains("+")) Console.WriteLine($"{a} + {b} = {a + b}");
			else if (expression.Contains("-")) Console.WriteLine($"{a} - {b} = {a - b}");
			else if (expression.Contains("*")) Console.WriteLine($"{a} * {b} = {a * b}");
			else if (expression.Contains("/")) Console.WriteLine($"{a} / {b} = {a / b}");
			else Console.WriteLine("Error: No operation");
		}
	}
}
