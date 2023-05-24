//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//////YIELD RETURN
//////CASTING
//////
//////
//////
//////


//namespace ConsoleApp1.CodeWars
//{

//    public class Class2
//    {
//        static void Main()
//        {

//            foreach (char item in IfUpper())
//            {
//                Console.WriteLine(item);
//            }

//        }

//        public static IEnumerable<char> IfUpper()
//        {
//            char A;
//            string text = "Hello World";
//            char[] Letters = text.ToCharArray();

//            //IEnumerable Sentence = Letters;
//            //foreach (char s in Sentence)
//            //{
//            //    yield return s;
//            //}

//            //IEnumerator enumerator = Letters/*Sentence*/.GetEnumerator();

//            //while (enumerator.MoveNext())
//            //{
//            //    //Casting
//            //    A =(char)enumerator.Current;
//            //    yield return A;
//            //}


//            //OR MAKE A SELECTION AND RETURN USING  IENUMERABLE
//            IEnumerable Sentence = from l in Letters where char.IsUpper(l) select l;
//            foreach (char item in Sentence)
//            {
//                yield return item;
//            }
//            //OR MAKE A SELECTION AND RETURN USING  IENUMERATOR
//            IEnumerator enumerator = Sentence.GetEnumerator();
//            while (enumerator.MoveNext())
//            {
//                A = (char)enumerator.Current;
//                yield return A;
//            }
//        }
//    }
//}



