//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Multiples of 3 or 5 
////https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp
////ienumerable uses with LINQ AND RANGE TO CREATE ienumerable




//namespace ConsoleApp1.CodeWars
//{

//    public class Class2
//    {
//        static void Main()
//        {

//            int result = 4 % 4;
//            Console.WriteLine(result);



//            Console.WriteLine(Solution(10));
//            Console.WriteLine(Solution2(10));
//            Solution3(10);

//        }


//        public static int Solution(int value)
//        {
//            List<int> list1 = new List<int>();

//            for(int i = value; i > 0; i--)
//            {
//                if(i>=3)
//                {
//                    list1.Add(i);
//                }            

//            }


//            List<int> list2 = new List<int>();

//            for(int i = 1; i < list1.Count; i++)
//            {
//                if(list1[i] %3==0 && list1[i]%5==0)
//                {
//                    list2.Add(list1[i]);
//                }
//                else if(list1[i] % 3 == 0 || list1[i] % 5 == 0)
//                {
//                    list2.Add(list1[i]);
//                }

//            }

//            int result=list2.Sum();

//            if (result > 0)
//            {
//                return result;
//            }

//            else
//            {
//                return 0;
//            }

//        }

//        //is better
//        public static int Solution2(int value)
//        {
//            IEnumerable<int> list = Enumerable.Range(0, value);
//            IEnumerable<int> list2 = from a in list where a % 3 == 0 || a % 5 == 0 select a;
//            int result = list2.Sum();
//            return result;

//        }

//        //is the best
//        public static void Solution3(int value)
//        {
//            int result =Enumerable.Range(0, value).Where(e => e % 3 == 0 || e % 5 == 0).Sum();
//            Console.WriteLine(result);
//        }

        
         //the superior
//     public static class Kata
//        {
//          public static int Solution(int value) => Enumerable.Range(0, value).Sum(i => i % 3 == 0 || i % 5 == 0 ? i : 0);
//        }



//    }

//}

