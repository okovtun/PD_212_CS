using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	class Rectangle : Shape
	{
		double side_a;
		double side_b;
		public double SideA
		{
			get { return side_a; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value > MAX_SIZE) value = MAX_SIZE;
				side_a = value;
			}
		}
		public double SideB
		{
			get { return side_b; }
			set
			{
				if (value < MIN_SIZE) value = MIN_SIZE;
				if (value > MAX_SIZE) value = MAX_SIZE;
				side_b = value;
			}
		}
		public Rectangle(double side_a, double side_b, int start_x, int start_y, int line_width, Color color) 
			: base(start_x, start_y, line_width, color)
		{
			SideA = side_a;
			SideB = side_b;
		}
		public double GetDiagonal()
		{
			return Math.Sqrt(Math.Pow(SideA, 2) + Math.Pow(SideB, 2));
		}
		public override double GetArea()
		{
			return SideA * SideB;
		}
		public override double GetPerimeter()
		{
			return (SideA + SideB) * 2;
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawRectangle(pen, StartX, StartY, (int)SideA, (int)SideB);
		}
		public override void Info(PaintEventArgs e)
		{
			Console.WriteLine($"Сторона А: {SideA}");
			Console.WriteLine($"Сторона B: {SideB}");
			Console.WriteLine($"Диагональ: {GetDiagonal()}");
			base.Info(e);
		}
	}
}
