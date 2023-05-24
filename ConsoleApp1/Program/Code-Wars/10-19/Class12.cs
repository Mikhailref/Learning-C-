//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////CREATE AN ARRAY WITH FOR LOOP WITH N SELLS
////REVERSE THE ARRAY
////Array.Reverse(array);
////LINQ

////Reversed sequence
////https://www.codewars.com/kata/5a00e05cc374cb34d100000d/train/csharp
////
////Build a function that returns an array of integers from n to 1 where n>0.
////Example: n = 5-- > [5, 4, 3, 2, 1]
////


//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {

//        public static Array Reverse(int n)
//        {
//            //int[] array=new int [n];
//            //for (int i = 0; i < n; i++)
//            //{
//            //    array[i] = i+1;

//            ////or 
//            ////array[i] = n-i;
//            ////do not have to Reverse then

//            //}
//            //Array.Reverse(array);
//            //return array;


//            //or
//            //var array2= Enumerable.Range(0, n).Reverse().ToArray();
//            //return array2;

//            //or
//            //var array3=new int [n];
//            //array3 = Enumerable.Range(0, n).Select(x => n - x).ToArray();         
//            //return array3;

//            //or
//            var array3 = new int[n].Select(x => n--).ToArray();
//            return array3;
//            //return new int[n].Select(x => n--).ToArray();
//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(Reverse(5));
//        }

//    }
//}

