//#define CONSTRUCTORS_CHECK
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
	class Program
	{
		static void Main(string[] args)
		{
#if CONSTRUCTORS_CHECK
			Fraction A = new Fraction();

			A.Integer = 123;
			A.Numerator = 456;
			A.Denominator = 789;
			Console.WriteLine(A);

			Fraction B = new Fraction(5);
			B.Print();
			Console.WriteLine(B);

			Fraction C = new Fraction(2, 3);
			C.Print();
			Console.WriteLine(C);

			Fraction D = new Fraction(2, 3, 4);
			D.Print();
			Console.WriteLine(D);

			Fraction E = new Fraction(D);
			Console.WriteLine(E); 
#endif
			Fraction A = new Fraction(2, 3, 4);
			Fraction B = new Fraction(3, 4, 5);
			Fraction C = A * B;
			Console.WriteLine($"{A} * {B} = {C}");
			Console.WriteLine($"{A} / {B} = {A/B}");

			Fraction D = new Fraction(2.75);
			Console.WriteLine(D);
		}
	}
}
