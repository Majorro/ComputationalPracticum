using ComputationalPracticum.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    public partial class ODECalculator : Form
    {
        public ODECalculator()
        {
            InitializeComponent();
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            solutionChart.Series["Euler's method total errors"].Points.Clear();
            solutionChart.Series["Improved Euler's method total errors"].Points.Clear();
            solutionChart.Series["Runge-Kutta method total errors"].Points.Clear();

            try
            {
                var startX = double.Parse(x0TextBox.Text);
                var initialValue = double.Parse(y0TextBox.Text);
                var endX = double.Parse(xTextBox.Text);
                var n = int.Parse(nTextBox.Text);

                if (endX - startX < 0)
                {
                    MessageBox.Show("Incorrect input");
                    return;
                }

                if(n < 3 || endX - startX >= n)
                {
                    MessageBox.Show("Too small N");
                    return;
                }

                solutionChart.ChartAreas["Solutions"].AxisX.Interval = (endX - startX) / Math.Min(25.0, n);
                solutionChart.ChartAreas["LocalErrors"].AxisX.Interval = (endX - startX) / Math.Min(25.0, n);
                //solutionChart.ChartAreas["MaxErrors"].AxisX.Interval = ;

                for (int steps = 2; steps <= n; ++steps)
                {
                    var euler = new EulerMethod(steps, startX, endX, initialValue, CalculationConstants.Derivative);
                    var improvedEuler = new ImprovedEulerMethod(steps, startX, endX, initialValue, CalculationConstants.Derivative);
                    var rungeKutta = new RungeKuttaMethod(steps, startX, endX, initialValue, CalculationConstants.Derivative);

                    solutionChart.Series["Euler's method total errors"].Points.AddXY(steps, euler.MaxError);
                    solutionChart.Series["Improved Euler's method total errors"].Points.AddXY(steps, improvedEuler.MaxError);
                    solutionChart.Series["Runge-Kutta method total errors"].Points.AddXY(steps, rungeKutta.MaxError);

                    if (steps == n)
                    {
                        var exact = new ExactSolution(steps, startX, endX, initialValue, CalculationConstants.Function);

                        solutionChart.Series["Exact solution"].Points.DataBindXY(exact.X, exact.Y);
                        solutionChart.Series["Euler's method"].Points.DataBindXY(euler.X, euler.Y);
                        solutionChart.Series["Improved Euler's method"].Points.DataBindXY(improvedEuler.X, improvedEuler.Y);
                        solutionChart.Series["Runge-Kutta method"].Points.DataBindXY(rungeKutta.X, rungeKutta.Y);

                        solutionChart.Series["Euler's method local errors"].Points.DataBindXY(euler.X, euler.LocalErrors);
                        solutionChart.Series["Improved Euler's method local errors"].Points.DataBindXY(improvedEuler.X, improvedEuler.LocalErrors);
                        solutionChart.Series["Runge-Kutta method local errors"].Points.DataBindXY(rungeKutta.X, rungeKutta.LocalErrors);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Incorrect input");
            }
        }
    }
}