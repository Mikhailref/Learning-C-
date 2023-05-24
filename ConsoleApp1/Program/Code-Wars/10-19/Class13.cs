//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////RETURN TRUE OR FALSE

////Is he gonna survive?
////https://www.codewars.com/kata/59ca8246d751df55cc00014c/train/csharp
////A hero is on his way to the castle to complete his mission.
////However, he's been told that the castle is surrounded with a
////couple of powerful dragons! each dragon takes 2 bullets to be
////defeated, our hero has no idea how many bullets he should carry..
////Assuming he's gonna grab a specific given number of bullets and move
////forward to fight another specific given number of dragons, will he survive?
////Return True if yes, False otherwise :)



//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {

//        public static bool Castle(int bullets, int dragons)
//        {

//            if(dragons <= bullets/2)
//            {
//                return true;
//            }
//            return false;

//            //or
//            // return bullets / 2 >= dragons;
//            //return bullets>=dragons*2;
//        }

//        //OR
//        public static bool Hero(int bullets, int dragons) => dragons * 2 <= bullets;

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(Castle(10,5));
//            Console.WriteLine(Hero(10,5));
//        }

//    }
//}

