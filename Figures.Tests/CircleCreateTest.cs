using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Tests
{
    public class CircleCreateTest
    {
        [Fact]
        public void FactoryMethod_MultipleParam_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CircleCreate().FactoryMethod(1, 2));
        }
    }
}
