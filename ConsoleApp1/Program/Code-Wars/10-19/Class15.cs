//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////NEGATIVE TO POSITIVE


////Twice as old
////https://www.codewars.com/kata/5b853229cfde412a470000d0/train/csharp
////Your function takes two arguments:
////current father's age (years)
////current age of his son (years)
////Сalculate how many years ago the father was twice as old as his son
////(or in how many years he will be twice as old).



//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {

//        public static double AGE(double father, double son)
//        {
//            double HowMany;
//            double Positive;
//            double AGO = father / son;
//            if (AGO != 1)
//            {

//                HowMany = father - son * 2;
//                Positive=Math.Abs(HowMany);
               
//                return Positive;
//            }

//            else 
//            { 
//                return 0;
//            }

//            //or
//            //return Math.Abs(dadYears - sonYears * 2);

//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(AGE(30, 20));
//        }

//    }
//}

