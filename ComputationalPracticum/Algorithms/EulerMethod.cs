using ComputationalPracticum.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public class EulerMethod : NumericMethod
    {
        private readonly double[] _d;

        public EulerMethod(int n, double startX, double endX, double initialValue, Func<double, double, double> derivative) :
            base(n, startX, endX, initialValue)
        {
            _d = new double[n];
            _d[0] = Step * derivative(X[0], Y[0]);

            for (int i = 1; i < n; ++i)
            {
                Y[i] = double.IsInfinity(Y[i - 1] + _d[i - 1]) || double.IsNaN(Y[i-1])
                       ? double.NaN
                       : Y[i - 1] + _d[i - 1];
                _d[i] = Step * derivative(X[i], Y[i]);

                LocalErrors[i] = Math.Abs(Y[i] - CalculationConstants.Function(X[i], X[0], Y[0]));
                MaxError = Math.Max(MaxError, LocalErrors[i]);
            }
        }
    }
}