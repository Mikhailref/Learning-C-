//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////STRINGBUILDER
////FOR LOOP
////SWITCH CASE RETURN

////8kyu interpreters: HQ9+
////https://www.codewars.com/kata/591588d49f4056e13f000001
////If the input is 'H', return 'Hello World!'
////If the input is 'Q', return the input
////If the input is '9', return the full lyrics of 99 Bottles of Beer.
////It should be formatted like this:



//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {
//        public static string Song()
//        {
//            StringBuilder sb = new StringBuilder();
//            for (int i = 99; i > 0; i--)
//            {
//               sb.Append ($"{i}bottles of beer on the wall,{i}bottles of beer.\nTake one down and pass it around,{i - 1} bottles of beer on the wall.\n\n");
               
//            }
//            return sb.ToString();
//        }


//        public static string SameCase(char Letter)
//        {
//            switch (Letter)
//            {
//                case 'H':
//                    return "Hello World!";

//                case 'Q':
//                    return Letter.ToString();

//                case '9':
//                   return Song();

//                default:
//                    return null;
//            }
//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(SameCase('9'));
//        }

//    }
//}

