//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////codewars https://www.codewars.com/kata/541c8630095125aba6000c00

//namespace ConsoleApp1.CodeWars._40_50
//{
//    public class Digit
//    {
//        public long Num { get; set; }

//        public Digit()
//        {

//        }
//    }


//    public class Utilities
//    {
//        public string LongToString(long number) => number.ToString();
//        public int[] StringToArrayOfNumbers(string LongToString) => LongToString.Select(x => x - '0').ToArray();
//        public int SumOfArray(int[] ArrayOfIntFromString) => ArrayOfIntFromString.Sum();


//        public long MoreThanOneDigit(long number)
//        {
//            string Num = LongToString(number);
//            if (Num.Length > 1)
//            {
//                int[] ArrayOutOfString = StringToArrayOfNumbers(Num);
//                long Result = SumOfArray(ArrayOutOfString);
//                return MoreThanOneDigit(Result);
//            }
//            else
//                return number;
//        }
//    }


//    internal class Class48
//    {
//        public static void Main()
//        {
//            Console.WriteLine(DigitalRoot(129));
//        }

//        public static int DigitalRoot(long n)
//        {
//            Digit number = new Digit();
//            number.Num = n;

//            Utilities utilities = new Utilities();
//            return (int)utilities.MoreThanOneDigit(number.Num);

//        }

//    }


//}
