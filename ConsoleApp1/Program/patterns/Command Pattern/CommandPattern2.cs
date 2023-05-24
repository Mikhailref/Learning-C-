//using ConsoleApp1.Program.patterns.various;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{

//    /// <summary>
//    /// https://www.youtube.com/watch?v=GQzfF5EMD7o
//    ///BENEFITS
//    ///ARE TO USE COMMANDS IN OTHER CLASSES
//    ///TO CREATE NEW COMMANDS FROM EXICTING BY COUPLING THEM
//    /// </summary>
//    internal class CommandPattern2
//    {
//        public static void Main()
//        {

//            Calculator calculator = new Calculator();
//            AddCommand addCommand = new AddCommand(30);
//            calculator.CurrentValue = 0;
//            calculator.ExecutueCommand(addCommand);
//            Console.WriteLine(calculator.CurrentValue);
//            calculator.ExecutueCommand(new AddCommand(30));
//            Console.WriteLine(calculator.CurrentValue);
//            calculator.UnDoCommand();
//            Console.WriteLine(calculator.CurrentValue);
//            calculator.UnDoCommand();
//            Console.WriteLine(calculator.CurrentValue);
//        }

//    }

//    public class Calculator
//    {
//        public int CurrentValue { get; set; }
//        private List<int> History = new List<int>();

//        public Calculator()
//        {
//            CurrentValue = 0;
//        }

//        public void ExecutueCommand(AddCommand addCommand)
//        {
//            CurrentValue = addCommand.Execute(CurrentValue);
//            History.Add(CurrentValue);
//        }

//        public void UnDoCommand()
//        {
//            History.RemoveAt(History.Count - 1);
//            CurrentValue = History.Last();

//        }

//    }

//    public class AddCommand
//    {
//        public int _currentValue { get; set; }
//        private int _valueToAdd;
//        public AddCommand(int valueToAdd)
//        {
//            _valueToAdd = valueToAdd;

//        }

//        public int Execute(int currentValue)
//        {
//            _currentValue = currentValue;
//            _currentValue = _currentValue + _valueToAdd;
//            return _currentValue;
//        }


//    }
//}


