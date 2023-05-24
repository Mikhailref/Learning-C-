//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////WHILE
////USING INT TO AVOID DECIMAL NUMBERS
////MODULUS REMAINDER
////CONVERT NUMBER TO ARRAY OF NUMBERS
////FOR LOOP IN REVERSED ORDER
////MAKE A NUMBER FROM LIST OF NUMBERS(CHARS)

////Previous multiple of three
////https://www.codewars.com/kata/61123a6f2446320021db987d/train/csharp
//////CONVERT NUMBER TO ARRAY OF DIGITS(chars) AND BACKWARDS
////
////


//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {


//        public static int? PreviousMultipleOfThree(int n)
//        {
//            //List<int> list = new List<int>();
//            //int num;

//            //if (n % 3 == 0)
//            //{
//            //    return n;
//            //}
//            //else if (n % 3 != 0)
//            //{
//            //    int[] digits = n.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

//            //    for (int i = digits.Length - 1; i >= 0; i--)
//            //    {
//            //        if (digits[i] % 3 == 0)
//            //        {
//            //            list.Add(digits[i]);


//            //        }

//            //    }
//            //    list.Reverse();

//            //    num = int.Parse(string.Join("", list));

//            //    return num;
//            //    //num =list.Aggregate((a,b) => a + b);
//            //}
//            //return null;


//            //OR
//            while (n > 0)
//            {
//                if (n % 3 == 0)
//                    return n;

//                n /= 10;

//            }
//            return null;

//        }

//        public static void Main(string[] args)
//        {

//            Console.WriteLine(PreviousMultipleOfThree(362));

//            int a = 36;
//            Console.WriteLine(a /= 10);


//        }
//    }
//}

