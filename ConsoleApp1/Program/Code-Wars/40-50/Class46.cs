//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////codewars https://www.codewars.com/kata/585d7d5adb20cf33cb000235
//namespace ConsoleApp1.CodeWars._40_50
//{
//    internal class Class46
//    {

//        static void Main()
//        {
//            int[] array = new int[] { 1, 1, 1, 2, 1, 1 };
//            int num=GetUnique(array);

//            Console.WriteLine(num);
           

//        }

//        public static int GetUnique(IEnumerable<int> numbers)
//        {
//            int[] array=numbers.ToArray();
//            Array.Sort(array);
//            if (array[0] == array[1])
//            {
//                return array.Last();
//            }
//            else
//                return array.First();
//        }

//    }
//}
