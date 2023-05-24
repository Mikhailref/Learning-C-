//using ConsoleApp1.Program.YouTube;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////You are working on a project
////where you need to implement undo/redo
////functionality for user's actions. Which design
////pattern would you use to encapsulate the state
////of the system and provide a simple interface for
////clients to undo / redo actions ?

//namespace ConsoleApp1.Program.YouTube
//{
//    public class AddNumber
//    {
//        private int _number;
//        public AddNumber(int number)
//        {
//            _number = number;
//        }

//        public int Execute(int currentValue)
//        {
//            return currentValue += _number;
//        }

//    }


//    public class Calculator
//    {
//        private int _currentValue;
//        private List<int> History;
//        private AddNumber _addNumber;
//        public Calculator()
//        {
//            _currentValue = 0;
//            History = new List<int>();
//        }

//        public int Do(AddNumber addNumber)
//        {  
//            _currentValue = addNumber.Execute(_currentValue);
//            History.Add(_currentValue);
//            _addNumber = addNumber;
//            return _currentValue;
//        }

//        public int Undo()
//        {
//            History.RemoveAt(History.Count - 1);
//            return _currentValue = History.Last();
//        }

//        public int Redo()
//        {
//            return Do(_addNumber);
//        }




//    }




//    class Client
//    {
//        public static void Main()
//        {

//            Calculator calculator = new Calculator();
//            AddNumber addNumber = new AddNumber(15);
//            Console.WriteLine(calculator.Do(addNumber));
//            AddNumber addNumber1 = new AddNumber(25);
//            Console.WriteLine(calculator.Do(addNumber1));
//            Console.WriteLine(calculator.Undo());
//            Console.WriteLine(calculator.Redo());



//        }
//    }

//}
