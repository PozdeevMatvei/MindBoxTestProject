using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figures.Models;

namespace Figures.Factory
{
    public class CircleCreate : Creator
    {
        public override Circle FactoryMethod(params double[] values)
        {
            if (values.Length != 1)
                throw new ArgumentException("Круг не существует");
            return new Circle(values[0]);
        }
    }
}
