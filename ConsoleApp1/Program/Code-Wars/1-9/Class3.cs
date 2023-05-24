//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////TO RAISE TO POWER
////RECURSION https://www.youtube.com/watch?v=CcYi5eS3yqA
////SWITCH


//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {
//        public static int NumToPower(int num, int power)
//        {
//            //recursion
//            int product = 1;
//            for (int i = 0; i < power; i++)
//            {
//                //product=product*num;
//                product *= num;

//            }

//            return product;
//        }

//        static void Main(string[] args)
//        {

//            int power;
//            int num;

//            num = Convert.ToInt32(Console.ReadLine());
//            power = Convert.ToInt32(Console.ReadLine());


//            switch (power)
//            {
//                case 0:
//                case 1:
//                    Console.WriteLine("out of range");
//                    break;

               
//                case 2:
//                    power = 2;
//                    Console.WriteLine(NumToPower(num, power));
//                    break;

//                default:
//                    Console.WriteLine(NumToPower(num, power));
//                    break;
//            }

//            Console.WriteLine("----------------");

//            //or use a MATH CLASS
//            Console.WriteLine(Math.Pow(num, power));





//        }

//    }

//}
