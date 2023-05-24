//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars._40_50
//{
//    internal class Class47
//    {
//        static void Main()
//        {
//            int[] array = new int[] { 1, 1, 1, 3 };
//            int NumToSearchFor = 3;

//            if(BinarySearch(array, 0, array.Length, NumToSearchFor)!=-1)
//            {
//                Console.WriteLine("found");
//            }

//            else
//            Console.WriteLine("not found");


//        }

//        static int BinarySearch(int[]array, int left, int right, int NumToSearchFor)
//        {
//            Array.Sort(array);

//            if (left <= right)
//            {
//                int middle = (left + right)/2;

//                if(NumToSearchFor==array[middle])
//                {
//                    return NumToSearchFor;
//                }

//                else if(NumToSearchFor < array[middle])
//                {
//                    return BinarySearch(array,left,middle-1,NumToSearchFor);
//                }

//                else if (NumToSearchFor > array[middle])
//                {
//                    return BinarySearch(array,middle + 1, right, NumToSearchFor);
//                }

//            }

//            return -1;
//        }

//    }
//}
