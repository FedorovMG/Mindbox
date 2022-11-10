using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public bool IsRectangular { 
            get{
                double max = Math.Max(A, Math.Max(B, C));
                if (max == A)
                {
                    return A*A == B*B + C*C;
                }
                else if (max == B)
                {
                    return B*B == A*A + C*C;
                }
                else
                {
                    return C*C == B*B + A*A;
                }
            }
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override double Square()
        {
            double p = (A + B + C) / 2;
            double S = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            return S;
        }
    }
}