//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Can we divide it?
////https://www.codewars.com/kata/5a2b703dc5e2845c0900005a
//// Your task is to create the functionisDivideBy(or is_divide_by)
//// to check if an integer number is divisible by both integers a and b.

////A few cases:
////(-12, 2, -6)  ->  true
////(-12, 2, -5)  ->  false

////(45, 1, 6)    ->  false
////(45, 5, 15)   ->  true

////(4, 1, 4)     ->  true
////(15, -5, 3)   ->  true

//namespace ConsoleApp1
//{
//    class Program
//    {

//        public static bool isDividedBy(int a, int b, int number)
//        {

//            if (number % a == 0 & number % b == 0)
//            {
//                return true;
//            }

//            else
//                return false;

//            //switch (number % a)
//            //{
//            //    case (0):
//            //        return true;
//            //}

//            //return false;

//        }


//        //OTHER SOLUTIONS
//        //1
//        //  public static bool is_divide_by(int number, int a, int b) => 
//        //      number % a == 0 && number % b == 0;

//        //2
//        // public static bool is_divide_by(int number, int a, int b)
//        //  {
//        //      return number % a == 0 && number % b == 0;
//        //  }



//        public static void Main()
//        {

//            Console.WriteLine(isDividedBy(2, 3, 5));
//        }

//    }
//}



