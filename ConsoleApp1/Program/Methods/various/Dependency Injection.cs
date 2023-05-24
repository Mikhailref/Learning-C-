////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp1.CodeWars.patterns
////{
////    class Program
////    {
////        public static void Main()
////        {

////            Person person = new Person(new Leg());

////        }
////    }

////    public interface IParts
////    {
////        void PartIsDoing(string Sentence);
////    }


////    public class Hand : IParts
////    {
////        string Sentence = "Write";
////        public Hand()
////        {
////            PartIsDoing(Sentence);
////        }

////        public void PartIsDoing(string Sentence)
////        {
////            Console.WriteLine(Sentence);
////        }

////    }

////    public class Leg : IParts
////    {
////        string Sentence = "Walking";
////        public Leg()
////        {
////            PartIsDoing(Sentence);
////        }
////        public void PartIsDoing(string Sentence)
////        {
////            Console.WriteLine(Sentence);
////        }
////    }


////    public class Person
////    {
////        public Person(IParts parts)
////        {

////        }

////    }

////}






