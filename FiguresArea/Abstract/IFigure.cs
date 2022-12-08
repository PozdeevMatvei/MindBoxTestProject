using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibrary.Abstract
{
    public abstract class Figure
    {
        public virtual double Area { get; }

        public abstract double Perimetr { get; }
        public abstract Type Type { get; }
    }
}
