﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double height, double width)
        {
            this.Height = height;
            this.Width = width;
        }

        public double Height { get; private set; }
        public double Width { get; private set; }
        public override double CalculateArea()
        {
            return Height * Width;     
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Height + Width);
        }

        public override string Draw()
        {
            return base.Draw();
        }
    }
}
