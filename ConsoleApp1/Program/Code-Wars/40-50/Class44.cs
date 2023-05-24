//using System;
//using System.Collections.Generic;

////CODEWARS https://www.codewars.com/kata/62c93765cef6f10030dfa92b/train/csharp

//namespace ConsoleApp1.CodeWars._40_50
//{
//    internal class Class44
//    {
//        //static void Main()
//        //{
//        //    Console.WriteLine("hello");

//        //    Console.WriteLine(Cats(1, 5));

//        //}

//        public static int Cats(int start, int finish)
//        {
//            double shelves = finish - start;
//            double steps = shelves / 3;


//            int rounded=(int)Math.Round(steps);

//            if(shelves==1)
//            {
//                rounded = rounded + 1;
//            }

//            else if (shelves == 2)
//            {
//                return rounded;
//            }

//            else if (steps>rounded) 
//            {
//                rounded=rounded+1;
//            }

//            else if(steps<rounded)
//            {
//                return rounded;
//            }
            
//            return rounded;
//        }


//        //WHILE

//        //public static int Cats(int start, int finish)
//        //{
//        //    int shelves = finish - start;


//        //    while(shelves%3!=0)
//        //    {
//        //        shelves=shelves+2;
//        //    }

//        //    return shelves / 3;

//        //}




//        //RECURSION

//        //static  List<int> list = new List<int>();

//        //public static int Cats(int start, int finish)
//        //{

//        //    int shelves = finish - start;
//        //    int steps =0;

//        //    if (shelves % 3 == 0)
//        //    {      
//        //       steps = shelves / 3;           
//        //    }

//        //    else if (shelves % 3 != 0)
//        //    {
//        //        finish = finish + 2;
//        //        Cats(start, finish);
//        //    }

//        //    list.Add(steps);
//        //    steps = list[0];

//        //    return steps;

//        //}

//    }
//}
