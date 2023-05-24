//using ConsoleApp1.CodeWars._40_50;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////codewars https://www.codewars.com/kata/546f922b54af40e1e90001da

//namespace ConsoleApp1.CodeWars._40_50
//{

//    public class Alphabet 
//    {
//        public string Input { get; set; }

//        public string Reference { get; set; }
//        public string Output { get; set; }

//    }


//    public class Utilities
//    {
//        public char[] ReferenceToArray(string Reference ) => Reference.ToCharArray();
//        public string InputToNewSortedString(string Input) => new string(Input.Where(c => char.IsLetter(c)).ToArray());
//        public char[] InputSortedStringToLower(string InputSorted) => InputSorted.ToLower().ToCharArray();

//        //or
//        //public char[] InputToSortedLowerArray(string Input) =>(char[])(from letter in Input.ToLower() where Char.IsLetter(letter) select letter);


//        //BINARY SEARCH
//        public int[] OutputAsArrayOfInt(char[] ReferenceToArray, char[] InputSortedStringToLower)
//        {
//            Array.Sort(ReferenceToArray);

//            int CharToNum;
//            int[]OutputArray= new int[InputSortedStringToLower.Length];

//            int i= 0;
//            while (i < InputSortedStringToLower.Length)
//            {  
//                CharToNum = Array.BinarySearch(ReferenceToArray, InputSortedStringToLower[i]);
//                OutputArray[i] = CharToNum+1;
//                i++;

//            }
//            return OutputArray;

//        }


//        //O(n^2) COMPLEXITY
//        //public int[] OutputAsArrayOfInt(char[] AlphaToArray, char[] InputArrayToLower)
//        //{
//        //    int[] OutputArray = new int[InputArrayToLower.Length];

//        //    for (int i = 0; i < InputArrayToLower.Length; i++)
//        //    {
//        //        char Textletter = InputArrayToLower[i];
//        //        for (int j = 0; j < AlphaToArray.Length; j++)
//        //        {
//        //            char Alphaletter = AlphaToArray[j];
//        //            if (Textletter == Alphaletter)
//        //            {
//        //                int num = Array.IndexOf(AlphaToArray, Alphaletter) + 1;
//        //                OutputArray[i] = num;
//        //                break;
//        //            }
//        //        }
//        //    }
//        //    return OutputArray;
//        //}

//        public string OutputAsStringFromArray(int[] InputArray) => string.Join(" ", InputArray);


//    }



//    internal class Class45
//    {
//        static void Main()
//        {
//            string Alphabet = "abcdefghijklmnopqrstuvwxyz";
//            string InputText = "The sunset sets at twelve o' clock.";

//            Alphabet alphabet = new Alphabet();
//            alphabet.Reference = Alphabet;
//            alphabet.Input = InputText;

//            Utilities utilities = new Utilities();
//            char[]Reference=utilities.ReferenceToArray(alphabet.Reference);
//            string SortedInput= utilities.InputToNewSortedString(alphabet.Input);
//            char[] ArrayFromSortedInput=utilities.InputSortedStringToLower(SortedInput);
//            int[] OutputArray = utilities.OutputAsArrayOfInt(Reference,ArrayFromSortedInput);
//            string Output=utilities.OutputAsStringFromArray(OutputArray);
//            Console.WriteLine(Output);

          

//            //Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
//        }
//    }
//    //public static string AlphabetPosition(string text)
//    //{
//    //    string Alphabet = "abcdefghijklmnopqrstuvwxyz";
//    //    char[] Alpha = Alphabet.ToCharArray();

//    //    char[] Input = text.ToCharArray();




//    //    string str = new string(Input.Where(c => char.IsLetter(c)).ToArray());


//    //    char[] LettersOnly = str.ToLower().ToCharArray();

//    //    int[] Output = new int[LettersOnly.Length];

//    //    for (int i = 0; i < LettersOnly.Length; i++)
//    //    {
//    //        char letter = LettersOnly[i];
//    //        for (int j = 0; j < Alpha.Length; j++)
//    //        {
//    //            char alphaletter = Alpha[j];
//    //            if (letter == alphaletter)
//    //            {
//    //                int num = Array.IndexOf(Alpha, letter) + 1;
//    //                Output[i] = num;
//    //                break;
//    //            }
//    //        }

//    //    }

//    //    string numbers = string.Join(" ", Output);



//    //    return numbers;
//    //}
//}

