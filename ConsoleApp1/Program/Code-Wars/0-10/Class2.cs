//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class2
//    {
//        static void Main(string[] args)
//        {

//            Console.WriteLine(FirstNonRepeatingLetter("BAb"));

//        }

//        static string FirstNonRepeatingLetter(string input)
//        {
//            //CREATE A LIST OF CHARS FROM THE STRING
//            List<char> MyList = List(input);

//            //RETURN THE FIRST STRING WHICH IS NOT REPEATED IN THE LIST
//            return MyChar(MyList);

//        }

//        static List<char> List(string input)
//        {
//            //CREATE AN ARRAY OF CHARS FROM THE STRING
//            Char[] MyArray = input.ToCharArray();

//            //CREATE AND RETURN A LIST OF CHARS FROM THE ARRAY
//            List<char> MyList = MyArray.ToList();
//            return MyList;
//        }

//        //1 YOU HAVE A LIST OF CHARS. LOOP THROUGH IT COMPARING FIRST CHAR/STRING TO THE NEXT CHARS/STRINGS
//        static string MyChar(List<char> MyList)
//        {
//            char letter1;
//            char letter2;

//            for (int i = 0; i < MyList.Count; i++)
//            {
//                if (MyList.Count == 1)
//                {
//                    return MyList[i].ToString();
//                }

//                else
//                {
//                    letter1= MyList[i];
//                    string letter11=letter1.ToString().ToLower();

//                    for (int j = i + 1; j < MyList.Count; j++)
//                    {
//                        letter2 = MyList[j];
//                        string letter22=letter2.ToString().ToLower();

//                        if (letter11 == letter22)
//                        {
                            
//                            MyList=ReturnedList(MyList,letter11);

//                            i--;
                           
//                            break;
//                        }

//                        else if (MyList.Count == j + 1)
//                        {
//                            return MyList[i].ToString();
//                        }
//                    }

//                }



//            }

//            return "";
//        }


//        //if i have a list with the same letter being lower and uppercase i should
//        //delete both from the list and return a new list
//        static List<char> ReturnedList(List <char> inputList, string inputString)
//        {
//            char LowerChar= char.Parse(inputString.ToLower());
//            char UpperChar = char.Parse(inputString.ToUpper());

//            inputList.RemoveAll(x => x == LowerChar);
//            inputList.RemoveAll(x => x == UpperChar);

//            return inputList;
//        }
//    }
//}



