//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    public class Program
//    {
//         //https://www.youtube.com/watch?v=NU_1StN5Tkk&t=849s
//        //ABSTRACTION is ensured by the additional layer made by the property Amount.
//        //BankAccount and his private field _amount is separated from external consumers of the class
//        //by the property Amount

//        //ENCAPSULATION is ensured by private SET, thus
//        //only members of the BankAccount class can modify property Amount and its respetive field _amount
//        //so it will not be corrupted by external consumers
//        //account.Amount can not be reached



//        public static void Main()
//        {
//            BankAccount account = new BankAccount();
//            account.Add(10);
//            account.Subtract(100);


//        }
//    }

//    internal class BankAccount
//    {
//        private double _amount;
//        public double Amount
//        {
//            get
//            {
//                return _amount;
//            }
//            private set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("amount is not correct");
//                }
//                else
//                {
//                    _amount = value;
//                }

//            }
//        }


//        public BankAccount()
//        {
//            Amount = 0;
//            Console.WriteLine(Amount);
//        }

//        public void Add(double Number)
//        {
//            Amount += Number;
//            Console.WriteLine(Amount);
//        }

//        public void Subtract(double Number)
//        {
//            Amount -= Number;
//            Console.WriteLine(Amount);
//        }





//    }


//}
