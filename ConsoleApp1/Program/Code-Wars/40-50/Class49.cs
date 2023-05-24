//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

////code wars https://www.codewars.com/kata/57eb8fcdf670e99d9b000272

//namespace ConsoleApp1.CodeWars._40_50
//{
//    public class Alphabet
//    {
//        public string TheAlphabet { get; set; }
//        public string Language { get; set; }

//        public Alphabet(string theAlphabet, string language)
//        {
//            TheAlphabet = theAlphabet;
//            Language = language;
//        }

//        public char[] CharArrayFromTheAlphabet(string TheAlphabet)
//        {
//            char[] CharArray = TheAlphabet.ToCharArray();
//            return CharArray;
//        }

//        public int NumberOfLetter(char Letter, char[] CharArrayFromTheAlphabet)
//        {
//            int digit = Array.IndexOf(CharArrayFromTheAlphabet, Letter);
//            return digit + 1;
//        }


//    }

//    public class Input
//    {
//        public string Sentence { get; set; }

//        public Input(string sentence)
//        {
//            Sentence = sentence;
//        }

//        public string[] ArrayOfWords(string InputString)
//        {
//            string[] words = Regex.Split(InputString, @"\W+");
//            return words;
//        }

//        public char[] LetterFromWord(string InputWord)
//        {
//            char[] Letters = InputWord.ToCharArray();
//            return Letters;
//        }

//    }

//    public class Utilities
//    {
//        public int IndexOfBiggestNumber(int[] Digits)
//        {
//            int max = Digits.Max();
//            return Array.IndexOf(Digits, max);
//        }

//        public string StringToReturn(int Index, string[] ArrayOfWords)
//        {
//            string Word = ArrayOfWords[Index];
//            return Word;
//        }

//    }

//    public class Added
//    {
//        public string ToLowerCase(string Input)
//        {
//            return Input.ToLower();
//        }
//    }




//    internal class Class49
//    {
//        public static void Main()
//        {

//            string Result = High("man i need a taxi up to ubud");

//            Console.WriteLine(Result);

//        }
//        public static string High(string s)
//        {
//            Added added = new Added();

//            Alphabet alphabet = new Alphabet("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "English");
//            alphabet.TheAlphabet = added.ToLowerCase(alphabet.TheAlphabet);

//            char[] CharsFromAlphabet = alphabet.CharArrayFromTheAlphabet(alphabet.TheAlphabet);

//            Input input = new Input(s);
//            input.Sentence = added.ToLowerCase(input.Sentence);

//            string[] Words = input.ArrayOfWords(input.Sentence);

//            Utilities utilities = new Utilities();

//            List<int> IntsFromLetter = new List<int>();

//            foreach (string word in Words)
//            {
//                char[] Letters = input.LetterFromWord(word);

//                int num = 0;

//                foreach (char letter in Letters)
//                {
//                    num = num + alphabet.NumberOfLetter(letter, CharsFromAlphabet);
//                }

//                IntsFromLetter.Add(num);
//            }

//            int[] Array = IntsFromLetter.ToArray();

//            int TheBiggest = utilities.IndexOfBiggestNumber(Array);

//            string Result = utilities.StringToReturn(TheBiggest, Words);
//            return Result;

//        }

//    }

//}
