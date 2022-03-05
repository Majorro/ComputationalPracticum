using ComputationalPracticum.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public abstract class NumericMethod : Grid
    {
        public double[] LocalErrors { get; private set; }
        public double MaxError { get; protected set; } = 0;

        public NumericMethod(int n, double startX, double endX, double initialValue) :
            base(n, startX, endX)
        {
            Y[0] = initialValue;
            LocalErrors = new double[n];
        }
    }
}
