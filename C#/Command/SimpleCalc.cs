using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    class SimpleCalc
    {
        private double sum;
        private double diff;

        public SimpleCalc()
        {
            Console.WriteLine("CALCULATOR: Creating calculator");
            diff = 0;
            sum = 0;

        }
        public double Sum(List<double> digits)
        {
            Console.WriteLine("CALCULATOR: Calculating sum");

            foreach(double digit in digits)
            {                
                sum += digit;
            }
            return sum;
        }
            
        public double Diff(List<double> digits)
        {
            Console.WriteLine("CALCULATOR: Calculating difference");

            foreach (double digit in digits)
            {
                diff -= digit;
            }
            return diff;
        }
    }
}
