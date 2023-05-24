//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class1
//    {
//        static List<char> myInputList = new List<char>();
//        static List<char> myOutputList = new List<char>();
//        static void Main()
//        {
//            string input = "I am working";
//            myInputList = SeparatedList(input);
//            myOutputList = NoSpaceList(myInputList);
//            string output = Result(myOutputList);
//            Console.WriteLine("output");
//            Test("output");

//        }

//        public static List<char> SeparatedList(string input)
//        {
//            return myInputList = input.ToList();
//        }

//        public static List<char> NoSpaceList(List<char> myInputList)
//        {
//            for (int i = 0; i < myInputList.Count; i++)
//            {
//                if (myInputList[i] != ' ')
//                {
//                    myOutputList.Add(myInputList[i]);
//                }
//            }
//            return myOutputList;
//        }

//        public static string Result(List<char> myOutputList)
//        {
//            return string.Join("", myOutputList);

//            //return input.Replace(" ", string.Empty);
//            //return input.Replace(' ', '-');
//        }

//        public static void Test(string Result)
//        {
//            Result.ToArray();

//            for (int i = 0; i < Result.Length; i++)
//            {
//                if (Result[i] == ' ')
//                {
//                    Console.WriteLine($"test failed at character {i}");
//                    break;

//                }

//                else if (Result.Length == i + 1)
//                {
//                    Console.WriteLine("test passed");
//                }


//            }





//        }
//    }
//}
