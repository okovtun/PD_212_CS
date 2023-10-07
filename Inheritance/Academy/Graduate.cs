using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
				string lastName, string firstName, int age,
				string speciality, string group, double rating, double attendance,
				string subject
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t {this.GetHashCode()}");
		}
		public Graduate(Graduate other) : base(other)
		{
			this.Subject = other.Subject;
			Console.WriteLine($"GCopyConstructor:{this.GetHashCode()}");
		}
		~Graduate()
		{
			Console.WriteLine($"GDestructor:\t {this.GetHashCode()}");
		}

		public override string ToString()
		{
			return base.ToString() + $", {Subject}";
		}
		public override void Init(string[] values)
		{
			base.Init(values);
			Subject = values[8];
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Sybject: " + Subject);
		}
	}
}
