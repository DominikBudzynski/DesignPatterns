using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Command
{
    class AddCommand : ICommand
    {
        private SimpleCalc calculator;
        private List<double> digits;

        public AddCommand(SimpleCalc calculator, List<double> digits)
        {
            Console.WriteLine("COMMAND: Creating command");
            this.calculator = calculator;
            this.digits = digits;            
        }

        public void Execute()
        {
            Console.WriteLine("COMMAND: Executing command from invoker, delgating to logic");
            calculator.Sum(digits);
        }
    }
}
