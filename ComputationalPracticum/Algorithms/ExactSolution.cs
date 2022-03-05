using ComputationalPracticum.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public class ExactSolution : Grid
    {
        public ExactSolution(int n, double startX, double endX, double initialValue, Func<double, double, double, double> function) :
            base(n, startX, endX)
        {
            for (int i = 0; i < n; ++i)
                Y[i] = double.IsInfinity(function(X[i], startX, initialValue)) || (i>0 && double.IsNaN(Y[i - 1]))
                       ? double.NaN
                       : function(X[i], startX, initialValue);
        }
    }
}
