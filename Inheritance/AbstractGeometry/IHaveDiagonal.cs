﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	interface IHaveDiagonal
	{
		double GetDiagonal();
		void DrawDiagonal(PaintEventArgs e);
	}
}
