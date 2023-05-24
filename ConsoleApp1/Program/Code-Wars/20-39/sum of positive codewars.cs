//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////SUM OF POSITIVE
////https://www.codewars.com/kata/5715eaedb436cf5606000381/train/csharp


//namespace ConsoleApp1.CodeWars
//{

//    public class Class2
//    {
//        public static void Main()
//        {
//            Console.WriteLine(PositiveSum(new int[] { 1, -4, 6, 8 }));
//        }

//        public static int PositiveSum(int[] arr)
//        {

//            IEnumerable<int> enumerable = from a in arr where a >= 0 select a;
//            int[] myArr2 = enumerable.ToArray();

//            if (myArr2.Count() == 0)
//            {
//                return 0;
//            }

            

//            else
//            {
//                int sum = 0;
//                for (int i = 0; i < myArr2.Length; i++)
//                {
//                    sum = myArr2[i] + sum;

//                }
//                return sum;
//            }

//        }

//        //public static int PositiveSum(int[] arr)
//        //{
//        //    return arr.Where(x => x > 0).Sum();
//        //}

//        //public static int PositiveSum(int[] arr)
//        //{
//        //    return arr.Sum(c => (c < 0 ? 0 : c));
//        //}

//        //public static int PositiveSum(int[] arr) => arr.Sum(i => i < 1 ? 0 : i);

//    }

//}



