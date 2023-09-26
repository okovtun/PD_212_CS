//#define LOGICAL_TYPES
//#define CHARACTER_TYPES
//#define INTEGRAL_TYPES
#define FLOATING_TYPES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static readonly string delimiter = "\n----------------------------------------------\n";
		static void Main(string[] args)
		{
			//Object
#if LOGICAL_TYPES
			Console.WriteLine("BOOL:");
			Console.WriteLine(sizeof(bool));    //Boolean
			Console.WriteLine(true.GetType());
			Console.WriteLine((3 + 2.5).GetType());
			Console.WriteLine(delimiter);
#endif

#if CHARACTER_TYPES
			Console.WriteLine("CHAR:"); //Хранит один символ в кодировке Unicode
			Console.WriteLine(sizeof(char));
			Console.WriteLine((int)(char.MinValue));
			Console.WriteLine((int)(char.MaxValue));
			Console.WriteLine(delimiter);
#endif

#if INTEGRAL_TYPES
			Console.WriteLine("SHORT");
			Console.WriteLine(sizeof(ushort));
			Console.WriteLine("USHORT:\t" + ushort.MinValue + " ... " + ushort.MaxValue);
			Console.WriteLine(" SHORT:\t" + short.MinValue + " ... " + short.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("INT");
			Console.WriteLine(sizeof(int));
			Console.WriteLine("UINT:\t" + uint.MinValue + " ... " + uint.MaxValue);
			Console.WriteLine("INT:\t" + int.MinValue + " ... " + int.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("LONG:");
			Console.WriteLine(sizeof(long));
			Console.WriteLine("ULONG:\t" + ulong.MinValue + " ... " + ulong.MaxValue);
			Console.WriteLine("ULONG:\t" + long.MinValue + " ... " + long.MaxValue); 
#endif

#if FLOATING_TYPES
			//float
			//double
			//deciaml
			Console.WriteLine("FLOAT:\t" + sizeof(float) + "Bytes");
			Console.WriteLine(float.MinValue + " ... " + float.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("DOUBLE:\t" + sizeof(double) + " Bytes");
			Console.WriteLine(double.MinValue + " ... " + double.MaxValue);
			Console.WriteLine(delimiter);

			Console.WriteLine("Decimal:\t" + sizeof(decimal) + " Bytes");
#endif
			Console.ReadLine();
		}
	}
}
