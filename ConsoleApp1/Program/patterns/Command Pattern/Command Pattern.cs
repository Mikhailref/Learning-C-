//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////https://medium.com/swlh/command-pattern-what-it-is-and-how-to-use-it-7ccbc810266d


//namespace ConsoleApp1.Program.patterns.various
//{
//    public interface ICommand
//    {
//        void Execute();

//    }

//    public class AddCommand : ICommand
//    {
//        private readonly Calculator calculator;
//        private readonly int value;

//        public AddCommand(Calculator Calculator, int Value)
//        {
//            calculator = Calculator;
//            value = Value;
//        }

//        public void Execute()
//        {
//            calculator.Add(value);
//        }


//    }

//    public class SubtractCommand : ICommand
//    {
//        private readonly Calculator calculator;
//        private readonly int value;


//        public SubtractCommand(Calculator Calculator, int Value)
//        {
//            calculator = Calculator;
//            value = Value;
//        }

//        public void Execute()
//        {
//            calculator.Subtract(value);
//        }


//    }

//    // other command classes for multiplication and division

//    public class Calculator
//    {
//        public int Value { get; set; }

//        public void Add(int num)
//        {
//            Value += num;
//        }

//        public void Subtract(int num)
//        {
//            Value -= num;
//        }

//        // other methods for multiplication and division

//        public void ExecuteCommand(ICommand command)
//        {
//            command.Execute();
//        }
//    }

//    public class Programm
//    {

//        public static void Main()
//        {
//            Calculator calculator = new Calculator();
//            AddCommand addCommand = new AddCommand(calculator, 5);
//            SubtractCommand subtractCommand = new SubtractCommand(calculator, 3);

//            Console.WriteLine(calculator.Value);

//            calculator.ExecuteCommand(addCommand); // adds 5 to the current value
//            Console.WriteLine(calculator.Value);


//            calculator.ExecuteCommand(subtractCommand); // subtracts 3 from the current value
//            Console.WriteLine(calculator.Value);


//            ///not exactly, there is no INVOKER


//        }
//    }
//}
