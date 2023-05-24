//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////codewars https://www.codewars.com/kata/6344701cd748a12b99c0dbc4/train/csharp

//namespace ConsoleApp1.CodeWars._40_50
//{
//    public class Word
//    {
//        public char[] ArrayOfChars { get; set; }
//        public char firstLetter { get; set; }
//        public char lastLetter { get; set; }

//    }

//    public class Utilities
//    {

//        public static char[] ArrayFromWord(string Word)
//        {
//            char[] array = Word.ToCharArray();
//            return array;
//        }

//        public static char FirstLetterFromWords(char[] ArrayFromWord)
//        {
//            char FirstLetter = ArrayFromWord.First();
//            return FirstLetter;
//        }
//        public static char LastLetterFromWords(char[] ArrayFromWord)
//        {
//            char LastLetter = ArrayFromWord.Last();
//            return LastLetter;
//        }


//        public static List<char> ResultantArray(List<char> listOfFirstLetters, List<char> listOfLastLetters)
//        {

//            for (int i = 0; i < listOfFirstLetters.Count; i++)
//            {
//                for (int j = 0; j < listOfLastLetters.Count; j++)
//                {
//                    if (i == j)
//                    {
//                        //do nothing
//                    }

//                    else if (listOfFirstLetters[i] == listOfLastLetters[j])
//                    {
//                        listOfFirstLetters[i] = ' ';
//                        listOfLastLetters[j] = ' ';
//                    }
//                }

//            }

//            return listOfFirstLetters;
//        }

//        public static bool Analization(List<char> listOfFirstLetters)
//        {
//            while (listOfFirstLetters.Contains(' '))
//            {
//                listOfFirstLetters.Remove(' ');
//            }


//            if (listOfFirstLetters.Count <= 1)
//            {
//                return true;

//            }
//            return false;
//        }


//    }


//    internal class Class50
//    {

//        public static void Main()
//        {
//            Console.WriteLine(Millipede(new string[] { "trade", "pole", "view", "grave", "ladder", "mushroom", "president" }));
//        }

//        public static bool Millipede(string[] arr)
//        {
//            Word word = new Word();


//            List<char> ListOfFirsLetters = new List<char>();
//            List<char> ListOfLastLetters = new List<char>();

//            foreach (string name in arr)
//            {
//                word.ArrayOfChars = Utilities.ArrayFromWord(name);
//                word.firstLetter = Utilities.FirstLetterFromWords(word.ArrayOfChars);
//                ListOfFirsLetters.Add(word.firstLetter);
//                word.lastLetter = Utilities.LastLetterFromWords(word.ArrayOfChars);
//                ListOfLastLetters.Add(word.lastLetter);

//            }


//            ListOfFirsLetters = Utilities.ResultantArray(ListOfFirsLetters, ListOfLastLetters);

//            return Utilities.Analization(ListOfFirsLetters);

//        }
//    }
//}
