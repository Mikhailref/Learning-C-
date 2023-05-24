//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.CompilerServices;
//using System.Text;
//using System.Threading.Tasks;

/////
//////////https://www.pvsm.ru/programmirovanie/7615
/////

//namespace ConsoleApp1.Program.Methods.various.Delegates
//{
//    internal class Delegates_Use
//    {
//        public static void Main()
//        {
//            double result = Calculator.PerformOperation("+", 10, 10);
//            result = Calculator.PerformOperation("/", 10, 10);
//            Console.WriteLine(result);

//            double result2 = Calculator.DoSubtraction(10, 10);
//            Console.WriteLine(result2);

//            Computer computer = new Computer();
//            computer.ComputeOperation(2, 3, computer.DoAddition);

//            computer.AddOperation("/", (x, y) => x / y);

//            computer.PerformOperation("/", 25, 5);

//        }

//    }

//    public static class Calculator
//    {
//        public static double PerformOperation(string operation, double x, double y)
//        {
//            switch (operation)
//            {
//                case "+": return x + y;
//                case "-": return x - y;
//                case "*": return x * y;
//                case "/": return x / y;
//                default: throw new ArgumentException(string.Format("Operation {0} is invalid", operation), "operation");
//            }
//        }


//        public static double DoDivision(double x, double y) => x / y;
//        public static double DoMultiplication(double x, double y) => x * y;
//        public static double DoSubtraction(double x, double y) => x - y;
//        public static double DoAddition(double x, double y) => x + y;

//    }

//    public class Computer
//    {
//        public delegate double OperationDelegate(double x, double y);

//        public double DoDivision(double x, double y) => x / y;
//        public double DoMultiplication(double x, double y) => x * y;
//        public double DoSubtraction(double x, double y) => x - y;
//        public double DoAddition(double x, double y) => x + y;

//        private Dictionary<string, OperationDelegate> _operations;

//        //Func<double, double, double>
//        //эквивалентно
//        //delegate double Delegate(double x, double y)
//        private Dictionary<string, Func<double, double, double>> _operations2;

//        public Computer()
//        {
//            _operations = new Dictionary<string, OperationDelegate>
//            {
//               { "+", delegate(double x, double y) { return x + y; } },
//               { "-", delegate(double x, double y) { return x - y; } },
//               { "*", this.DoMultiplication },
//               { "/", this.DoDivision },
//            };

//            _operations2 = new Dictionary<string, Func<double, double, double>>
//            {
//                { "+", (x, y) => x + y },
//                { "-", (x, y) => x - y },
//            };

//        }

//        public double ComputeOperation(double x, double y, OperationDelegate CallBack)
//        {
//            double result = CallBack(x, y);
//            Console.WriteLine(result);
//            return result;
//        }

//        public void AddOperation(string operatorString, Func<double, double, double> operation)
//        {
//            _operations2[operatorString] = operation;
//        }

//        public double PerformOperation(string operation, double x, double y)
//        {
//            if (!_operations2.ContainsKey(operation))
//            throw new ArgumentException(string.Format("Operation {0} is invalid", operation), "op");

//            double result = _operations2[operation](x, y);
//            Console.WriteLine(result);
//            return result;
//        }



//    }



//}
