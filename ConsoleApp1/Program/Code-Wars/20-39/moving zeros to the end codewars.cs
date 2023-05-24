//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


////moving zeros to the end
////https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp


//namespace ConsoleApp1.CodeWars
//{
//    public class Class2
//    {
//        static void Main()
//        {

//            int[] result = MoveZeroes2(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });


//        }
//        public static int[] MoveZeroes(int[] InputArray)
//        {
//            IEnumerable<int> WithoutZeros = InputArray.Where(x => x > 0 || x<0);
//            IEnumerable<int> AllZeros=InputArray.Where(x => x == 0);
//            IEnumerable concatenated = WithoutZeros.Concat(AllZeros).ToArray();
//            int[] result = (int[])concatenated;

            
//            foreach (object i in concatenated)
//            {
//                Console.WriteLine(i);
//            }

//            IEnumerator numerator =concatenated.GetEnumerator();

//            while(numerator.MoveNext())
//            {
//                Console.WriteLine(numerator.Current);
//            }

//            return result;

//            //OR
//            //return InputArray.Where(x => x != 0).Concat(InputArray.Where(x => x == 0)).ToArray();


//        }

//        //IS BETTER
//        public static int[] MoveZeroes2(int[] InputArray)
//        {
//            int[] resultarray = InputArray.OrderBy(x => x == 0).ToArray();
//            foreach (int i in resultarray)
//            {
//                Console.WriteLine(i);
//            }

//            return resultarray;

//            //OR I do not understand it
//            //int[]resultarray2=InputArray.OrderBy(0.Equals).ToArray();

//            //foreach(int x in resultarray2)
//            //{
//            //    Console.WriteLine(x);
//            //}
//            //return resultarray2;


//        }






//    }

//}

