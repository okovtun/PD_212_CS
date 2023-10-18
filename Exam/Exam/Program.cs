using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
	class Program
	{
		static void Main(string[] args)
		{
			Object[] arr = new Object[] { 2.5, 5, "Hello", true };
			foreach (Object i in arr)
			{
				Console.WriteLine(i);
			}
		}
	}
}
