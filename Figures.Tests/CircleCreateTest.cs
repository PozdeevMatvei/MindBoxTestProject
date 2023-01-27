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
        public void Create_MultipleParam_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new CircleCreate().Create(1, 2));
        }
    }
}
