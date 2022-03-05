using ComputationalPracticum.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public class RungeKuttaMethod : NumericMethod
    {
        public RungeKuttaMethod(int n, double startX, double endX, double initialValue, Func<double, double, double> derivative) :
            base(n, startX, endX, initialValue)
        {
            for(int i = 1; i < n; ++i)
            {
                double m = Step * derivative(X[i - 1], Y[i - 1]);
                double m2 = Step * derivative(X[i - 1] + Step / 2.0, Y[i - 1] + m / 2.0);
                double m3 = Step * derivative(X[i - 1] + Step / 2.0, Y[i - 1] + m2 / 2.0);
                double m4 = Step * derivative(X[i - 1] + Step, Y[i - 1] + m3);
                Y[i] = double.IsInfinity(Y[i - 1] + (m + 2.0 * m2 + 2.0 * m3 + m4) / 6.0) || double.IsNaN(Y[i - 1])
                       ? double.NaN
                       : Y[i - 1] + (m + 2.0 * m2 + 2.0 * m3 + m4) / 6.0;

                LocalErrors[i] = Math.Abs(Y[i] - CalculationConstants.Function(X[i], X[0], Y[0]));
                MaxError = Math.Max(MaxError, LocalErrors[i]);
            }
        }
    }
}