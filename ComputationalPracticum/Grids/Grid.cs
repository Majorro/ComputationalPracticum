using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputationalPracticum.Grids
{
    public abstract class Grid
    {
        protected readonly int n;

        public double[] X { get; private set; }
        public double[] Y { get; protected set; }
        public double Step { get; private set; } // h

        public Grid(int n, double startX, double endX )
        {
            this.n = n;
            Step = (endX - startX) / n;
            X = new double[n];
            Y = new double[n];


            for(int i = 0; i < n; ++i)
            {
                if (i == 0)
                    X[i] = startX;
                else
                    X[i] = X[i - 1] + Step;
            }
        }
    }
}
