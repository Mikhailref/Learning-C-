//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars._40_50
//{
//    internal class ienumerables
//    {
//        public static void Main()
//        {

//            //we have an array
//            int[] numbers = { 1, 2, 3, 4, 5 };

//            //create ienumerable using a condition and fiws statement
//            IEnumerable<int> From = from x in numbers where x > 3 select x;

//            //turn ienumerable into array
//            int[]digits=From.ToArray();

//            foreach (int digit in digits)
//            {
//                Console.WriteLine(digit);
//            }


//            //use shorten expression where/select/orderby and turn it into a new array
//            IEnumerable<int> Where = numbers.Where(x => x > 0).ToArray();
//            IEnumerable<int> Select = numbers.Select(x => x * x).ToArray();
//            IEnumerable<int> OrderBy = numbers.OrderBy(x => x).ToArray();
//            IEnumerable<int> Oftype = numbers.OfType<int>().ToArray();
            

//            foreach (int num in Where)
//            {
//                Console.WriteLine(num);
//            }





//        }
//    }
//}
