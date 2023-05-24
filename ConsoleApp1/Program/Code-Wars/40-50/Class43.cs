//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars._40_50
//{
//    //codewars https://www.codewars.com/kata/54fb963d3fe32351f2000102
//    internal class Class43
//    {
//        static void Main()
//        {
//            Console.WriteLine("hello");
//            Console.WriteLine(Collatz(20));
            
//        }

//        public static int Collatz(int n)
//        {

//            //create an array of numbers from n
//            //where if n is even divide it by 2
//            //if n is odd multiply it by 3 and add 1
//            //when it reaches the 1 count  all numbers received in array

//            List<int> numbers = new List<int>();

//            while (n != 0)
//            {
//                numbers.Add(n);

//                if (n == 1)
//                {
//                    break; 
//                }

//                else if (n % 2 == 0)
//                {
//                    n = n / 2;
//                }

//                else if (n % 2 != 0)
//                {
//                    n = n * 3 + 1;
//                }
//            }



//            int[] array = numbers.ToArray();
//            return array.Count();

        


//        }
//    }
//}
