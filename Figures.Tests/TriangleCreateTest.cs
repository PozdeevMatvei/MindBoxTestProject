using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures.Tests
{
    public class TriangleCreateTest
    {
        [Fact]
        public void FactoryMethod_NotThreeParam_ThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TriangleCreate().FactoryMethod(1));
        }
    }
}
