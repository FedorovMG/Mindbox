using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Geometry
{
    public abstract class Shape
    {
        public string Name { get; set; }
        abstract public double Square();
    }
}