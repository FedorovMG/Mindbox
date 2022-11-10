using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Square() => Math.PI * Radius*Radius;
    }
}