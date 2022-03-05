using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Algorithms
{
    public static class CalculationConstants
    {
        public static Func<double, double, double, double> Function = (x, x0, y0) => 1.0 / (1.0+x*(1.0-y0)/(y0*x0));
        public static Func<double, double, double> Derivative = (x, y) => (y * y - y) / x;
    }
}
