//#define WRITE_TO_FILE
#define READ_FROM_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
	class Program
	{
		public static readonly string delimiter = "\n---------------------------------------------------\n";
		static void Main(string[] args)
		{
#if WRITE_TO_FILE
			Human human = new Human("Vercetty", "Tommy", 30);
			//Console.WriteLine(human);
			//Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 90, 99);
			//Console.WriteLine(student);
			//Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			//Console.WriteLine(teacher);
			//Console.WriteLine(delimiter);

			Graduate graduate = new Graduate("Hank", "Schrader", 40, "Criminalistic", "OBN", 80, 70, "How to catch Heisenberg");
			//Console.WriteLine(graduate);
			//Console.WriteLine(delimiter);

			Student tommy = new Student(human, "Theft", "Vice", 98, 99);
			//Console.WriteLine(tommy);
			Console.WriteLine(delimiter);

			Human[] group = new Human[] { student, teacher, graduate, tommy,
				new Teacher("Diaz", "Ricardo", 50, "Weapons distribution", 25),
				new Graduate("Rosenberg", "Ken", 35, "Lower", "Vice", 44, 22, "Get money back")
			};
			Console.WriteLine(delimiter);
			for (int i = 0; i < group.Length; i++)
			{
				//Console.WriteLine(group[i]);
				group[i].Print();
				Console.WriteLine(delimiter);
			}

			Save(group, "group.csv"); 
#endif
			Human[] group = Load("group.txt");
			for (int i = 0; i < group.Length; i++)
			{
				Console.WriteLine(group[i]);
			}
		}
		static void Save(Human[] group, string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			string currentDirectory = Directory.GetCurrentDirectory();
			//string filename = "group.txt";
			StreamWriter sw = new StreamWriter(filename);
			for (int i = 0; i < group.Length; i++)
			{
				sw.WriteLine($"{group[i].GetType()}:\t{group[i]};");
			}
			sw.Close();

			string cmd = $"{currentDirectory}\\{filename}";
			System.Diagnostics.Process.Start("notepad", cmd);
		}
		static Human[] Load(string filename)
		{
			Directory.SetCurrentDirectory("..\\..");
			string currentDirectory = Directory.GetCurrentDirectory();
			List<Human> group = new List<Human>();
			StreamReader sr = new StreamReader(filename);
			while (!sr.EndOfStream)
			{
				string buffer = sr.ReadLine();
				string[] values = buffer.Split(':', ',');
				group.Add(HumanFactory(values[0]));
				group.Last().Init(values);
			}
			sr.Close();
			return group.ToArray();
		}
		static Human HumanFactory(string type)
		{
			Human human = null;
			if (type == typeof(Academy.Student).ToString()) human = new Student("", "", 0, "", "", 0, 0);
			if (type == typeof(Academy.Teacher).ToString()) human = new Teacher("", "", 0, "", 0);
			if (type == typeof(Academy.Graduate).ToString()) human = new Graduate("", "", 0, "", "", 0, 0, "");
			return human;
		}
	}
}
