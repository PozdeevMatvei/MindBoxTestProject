using Figures.Models;

namespace Figures.Factory
{
    public abstract class Creator
    {
        public abstract Shape Create(params double[] values);
    }
}
