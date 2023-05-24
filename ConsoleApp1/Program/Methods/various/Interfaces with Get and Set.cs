//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various.Interfaces
//{
//    public interface ICalculator
//    {
//        double CalculateTotalBalance();
//    }

//    public abstract class BaseCalculator : ICalculator
//    {

//        private double _totalBalance;

//        public double TotalBalance
//        {
//            get
//            {
//                return _totalBalance;
//            }
//            set
//            {
//                if (value < 0)
//                {
//                    throw new ArgumentException("_totalBalance cannot be negative.");
//                }
//                else
//                {
//                    _totalBalance = value;
//                }
                
//            }
//        }

//        protected BaseCalculator(double Number)
//        {
//            TotalBalance = Number;
//            Console.WriteLine(TotalBalance);
//        }

//        public double Add(double amount)
//        {
//            TotalBalance += amount;
//            return TotalBalance;
//        }

//        public double Subtract(double amount)
//        {
//            TotalBalance -= amount;
//            return TotalBalance;
//        }

//        public abstract double CalculateTotalBalance();
//    }


//    internal class Calculator1 : BaseCalculator
//    {
//        public Calculator1(double Number) : base(Number)
//        {
//        }

//        public override double CalculateTotalBalance()
//        {
//            return TotalBalance;
//        }
//    }

//    public class Programm
//    {

//        public static void Main()
//        {

//            BaseCalculator Mycalculator = getCalculator(-10);
//            //Mycalculator.Add(5);
//            //Mycalculator.Subtract(2);
//            //Console.WriteLine(Mycalculator.Calculate());


//            //Mycalculator.TotalBalance = -15;
//            //Console.WriteLine(Mycalculator.TotalBalance);


//        }

//        //you can use here interfaces as well
//        public static BaseCalculator getCalculator(double Amount)
//        {
//            return new Calculator1(Amount);
//        }


//    }



//}


