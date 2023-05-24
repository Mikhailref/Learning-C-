//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////PARSE AND TRYPARSE METHODS

//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {
//        public static decimal ParseMethod(string num)
//        {
           
//            if (decimal.TryParse(num, out decimal value))//WHEN NOT SUCCESSFUL IT RETURNS 0
//            {

//                Console.WriteLine("ok");

//            }

//            return value;
//        }

//        public static void Main(string[] args)
//        {
//            int g = Int32.Parse("12");
//            Console.WriteLine(g);
//            Console.WriteLine("---------------");

//            decimal A = decimal.Parse("12,0.000");
//            Console.WriteLine(A);
//            Console.WriteLine("---------------");

//            Console.WriteLine(ParseMethod("12,0,0.0.0"));

//            Console.WriteLine("---------------");

//            Console.WriteLine(ParseMethod("12,0,0.0"));

//        }

//    }
//}

