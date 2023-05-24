//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////TRUE AND NOT TRUE IN IF STATEMENTS
////IN IF STATEMENTS IF TRUE/FALSE IS EQUALorLOWERorGRATER TRUE/FALSE
////CHECK IF LETTER OR NOT
////CHECK IF LOWER CASE OR NOT
////CHECK IF DIGIT OR NOT
////USE CHAR INSTEAD OF VAR AS AN ARGUMENT

////Check same case
////    https://www.codewars.com/kata/5dd462a573ee6d0014ce715b/train/csharp
////    Write a function that will check if two given characters are the same case.

////If either of the characters is not a letter, return -1
////If both characters are the same case, return 1
////If both characters are letters, but not the same case, return 0
////Examples
////'a' and 'g' returns 1

////'A' and 'C' returns 1

////'b' and 'G' returns 0

////'B' and 'g' returns 0

////'0' and '?' returns -1




//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {

//        public static int SameCase(char a, char b)
//        {
//            if (!char.IsLetter(a) || !char.IsLetter(b))
//                return -1;
//            if (char.IsLower(a) == char.IsLower(b))
//            {
//                return 1;
//            }
//            else 
//            return 0;

//            //OR
//            //return char.IsLower(a) == char.IsLower(b) ? 1 : 0;

//        }

//        public static void Main(string[] args)
//        {
//            Console.WriteLine(SameCase('a', 'g'));
//            Console.WriteLine(SameCase('A', 'C'));
//            Console.WriteLine(SameCase('a', 'C'));
//            Console.WriteLine(SameCase('C', 'A'));
//            Console.WriteLine(SameCase('0', 'A'));
//        }

//    }
//}
