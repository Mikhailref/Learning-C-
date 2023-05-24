//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////codewars
////https://www.codewars.com/kata/58d3487a643a3f6aa20000ff

//namespace ConsoleApp1.CodeWars._40_50
//{
//    internal class Class41
//    {

//        static void Main()
//        {

//            Method();
//            MethodSecond();
//        }

//        public static int[] Method()
//        {
//            int[] array = new int[6] { 1, 5, 0, 2, 9, 7 };


//            int min;
//            int mid;
//            int max;
//            int[] minmidmax = new int[3];


//            min = array[0];
//            max = array[0];

//            for (int j = 1; j < array.Length; j++)
//            {
//                if (min > array[j])
//                {
//                    min = array[j];
//                }

//                if (max < array[j])
//                {
//                    max = array[j];
//                }
//            }


//            mid = min + 1;

//            int i = 0;
//            while (i < array.Length)
//            {
//                if (mid == array[i])
//                {
//                    mid++;
//                    i = 0;
//                }
//                i++;
//            }

//            minmidmax[0] = min;
//            minmidmax[1] = mid;
//            minmidmax[2] = max;

//            Console.WriteLine(min);
//            Console.WriteLine(mid);
//            Console.WriteLine(max);
//            return minmidmax;

//        }



//        public static int[] MethodSecond()
//        {
//            int[] array = new int[5] { 1, 4, 5, -23, 24 };


//            int min;
//            int mid;
//            int max;

//            min = array.Min();
//            max = array.Max();

//            mid = min + 1;

//            while(array.Contains(mid))
//            {
//                mid++;
//            }

//            Console.WriteLine(min);
//            Console.WriteLine(mid);
//            Console.WriteLine(max);
//            return new[] {min,mid,max};
//        }



//    }
//}

