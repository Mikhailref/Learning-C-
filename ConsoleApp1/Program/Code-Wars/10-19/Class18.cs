//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//LINQ to Objects
////LINQ https://metanit.com/sharp/tutorial/15.1.php
////VAR NAME = / IENUMERABLE<>NAME=
////FIWS VS LAMBDA
////FROM a IN aaaa  SELECT a
////FROM a IN aaaa WHERE a.method().method().condition().condition() ORDERBY a SELECT a
////aaaa.Where(a=>a.ToUpper().StartsWith("T")).OrderBy(a => a)
////
////IEnumerable convert to LIST
////IEnumerable convert to ARRAY
////create IEnumerable using ENUMERABLE
////
////TO CREATE LIST OR ARRAY USE LOOPS NOT LINQ
////USING LINQ WE CAN CREATE IENUMERABLE/INT FROM LIST OR ARRAY AND THEN CONVERT IT TO LIST OR ARRAY



//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {
//        //instead of LINQ we can use LOOP TO CREATE ARRAY FROM ARRAY OR LIST FROM LISTT

//        public static void SameCase(int num)
//        {
//            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

//            var selectedPeople = new List<string>();

//            foreach (string person in people)
//            {
//                if (person.ToUpper().StartsWith("T"))
//                {
//                    selectedPeople.Add(person);
//                }

//            }

//            selectedPeople.Sort();

//            foreach (string person in selectedPeople)
//                Console.WriteLine(person);


//        }



//        public static void Main(string[] args)
//        {
//            string[] people = { "tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

//            //create a list
//            List<string> myList = new List<string>();
//            //create a list
//            List<string> myList2 = new List <string> { "TOM", "MARK" };
//            myList2.Add("JON");
//            //create a list using var
//            var selectedPeopleList = new List<string>();
//            selectedPeopleList = people.ToList();
//            //or
//            var Mylist = people.ToList();
//            Console.WriteLine(selectedPeopleList[0]);
//            //create a list as IEnumerable
//            IEnumerable<string> peopleList = people.ToList();

//            //create an array
//            string[] myArray = new string [5];
//            //create an array
//            string[] myArray2 = new string [] { "TOM", "MARK" };
//            //create an array using var
//            var selectedPeopleArray = new string[4];
//            selectedPeopleArray = people.ToArray();
//            //or
//            var MyArray = people.ToArray();
//            Console.WriteLine(selectedPeopleArray[0]);
//            //create an array as IEnumerable
//            IEnumerable<string> peopleArray = people.ToArray();

//            //USING LINQ WE CAN CREATE IENUMERABLE/INT FROM LIST OR ARRAY
//            //LINQ операторы запросов
//            IEnumerable<string> selectedPeople1 = from p in people where p.StartsWith("T") orderby p select p;
//            var selectedPeople2 = from p in people where p.ToUpper().StartsWith("T") orderby p select p;
//            //OR USING LAMBDA
//            var selectedPeople3 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);

//            foreach (string s in selectedPeople2)
//                Console.WriteLine(s);

//            //OR (операторы запросов)+.метод расширения()
//            int number = (from p in people where p.ToUpper().StartsWith("T") select p).Count();
//            Console.WriteLine(number);
//            //LINQ


//            //IENUMERABLE
//            //OR create IEnumerable using method Enumerable
//            IEnumerable<int> values1 = Enumerable.Range(1, 10);
//            IEnumerable<int> values2 = Enumerable.Range(1, 10);
//            //Create IEnumerable using LINQ
//            var selectedPeople5 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);


//            //IEnumerable convert to list
//            List<int> valueList = values1.ToList();
//            Console.WriteLine(valueList[9]);

//            //IEnumerable convert to Array
//            int[] valueArray = values2.ToArray();
//            Console.WriteLine(valueArray[9]);
//            //IENUMERABLE




//        }

//    }
//}

