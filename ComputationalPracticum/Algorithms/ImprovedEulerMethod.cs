using ComputationalPracticum.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public class ImprovedEulerMethod : NumericMethod
    {
        public ImprovedEulerMethod(int n, double startX, double endX, double initialValue, Func<double, double, double> derivative) :
            base(n, startX, endX, initialValue)
        {
            for(int i = 1; i < n; ++i)
            {
                double m = derivative(X[i-1], Y[i-1]);
                double m2 = derivative(X[i], Y[i - 1] + Step * m);
                Y[i] = double.IsInfinity(Y[i - 1] + Step / 2.0 * (m + m2)) || double.IsNaN(Y[i - 1])
                       ? double.NaN 
                       : Y[i - 1] + Step / 2.0 * (m + m2);

                LocalErrors[i] = Math.Abs(Y[i] - CalculationConstants.Function(X[i], X[0], Y[0]));
                MaxError = Math.Max(MaxError, LocalErrors[i]);
            }
        }
    }
}