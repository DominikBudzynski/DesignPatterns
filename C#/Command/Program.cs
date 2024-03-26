using System;
using System.Runtime.CompilerServices;

namespace Command
{
    class Program
    {
        static void Main()
        {
            List<double> digits = new List<double>();
            digits.Append(1);
            digits.Append(2);
            digits.Append(3);

            SimpleCalc calc = new SimpleCalc();
            Invoker button = new Invoker(new AddCommand(calc, digits));
            button.ExecuteCommand();

        }
    }
}