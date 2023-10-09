using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Student: Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		public double Rating { get; set; }
		public double Attendance { get; set; }
		public Student
			(
				string lastName, string firstName, int age,
				string speciality, string group, double rating, double attendance
			) : base(lastName, firstName, age)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
			Console.WriteLine($"SConstructor:\t {this.GetHashCode()}");
		}
		public Student(Human human, string speciality, string group, double rating, double attendance) : base(human)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
		}
		public Student(Student other):base(other)
		{
			this.Speciality = other.Speciality;
			this.Group = other.Group;
			this.Rating = other.Rating;
			this.Attendance = other.Attendance;
			Console.WriteLine($"SCopyConstructor:{this.GetHashCode()}");
		}
		~Student()
		{
			Console.WriteLine($"SDestructor:\t {this.GetHashCode()}");
		}
		public override string ToString()
		{
			return base.ToString() + ", " + $"{Speciality}, {Group}, {Rating}, {Attendance}";
		}
		public override void Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4].TrimStart().TrimEnd();
			Group = values[5].TrimStart().TrimEnd();
			Rating = Convert.ToDouble(values[6]);
			Attendance = Convert.ToDouble(values[7]);
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Speciality:\t" + Speciality);
			Console.WriteLine("Group:\t\t" + Group);
			Console.WriteLine("Rating:\t\t" + Rating);
			Console.WriteLine("Attendance:\t" + Attendance);
		}
	}
}
