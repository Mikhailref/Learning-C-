//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////IF STATMENTS WITH MULTIPLE IF WITH TWO IF (=> IF(CONDITION)  ?(RETURN1)  :(RETURN2))

////Pillars
////https://www.codewars.com/kata/5bb0c58f484fcd170700063d/train/csharp
////There are pillars near the road. The distance between the pillars is the same and 
////the width of the pillars is the same. Your function accepts three arguments:
////number of pillars (≥ 1);
////distance between pillars (10 - 30 meters);
////width of the pillar (10 - 50 centimeters).
////Calculate the distance between the first and the last pillar in centimeters
////(without the width of the first and last pilla
////
////


//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {

//        public static int Pillars(int numPill, int dist, int width)
//        {
//            int Alldistance;
//            if (numPill > 2)
//            {
//                Alldistance = (numPill-1) * (dist*100)+(width*(numPill));
//                Alldistance = Alldistance-width*2;
//                return Alldistance;
//            }
         
//            else if (numPill == 2)
//            {
//                Alldistance = dist * 100;
//                return Alldistance;
//            }

//            else
//            {
//              return 0;
//            }


//            //OR
//            // return numPill > 1 ? --numPill * (100 * dist + width) - width : 0;

//            //OR
//            //=>numPill > 1 ? (numPill - 1) * dist * 100 + (numPill - 2) * width : 0;

//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(Pillars(2,10,10));
//        }

//    }
//}

