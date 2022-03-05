using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputationalPracticum
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ODECalculator());
            }
            catch (OverflowException e)
            {
                MessageBox.Show("Too big value to plot");
            }
            catch
            {
                throw;
            }
        }
    }
}
