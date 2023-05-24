//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////PRACTICE LINQ FROM CLASS 18
////https://metanit.com/sharp/tutorial/15.1.php
////USING LINQ WE CAN CREATE IEnumerable/int FROM LIST OR ARRAY


//namespace ConsoleApp1.CodeWars
//{
//    internal class Class2
//    {


//        public static void Loop()
//        {
//            //first we have an array of strings
//            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

//            //second make it list and find all names started from T
//            List<string> NewList = new List<string>();
//            //or
//            //var NewList1= new List<string>();

//            //third insert those names into a new list using loop

//            foreach (string person in people)
//            {
//                if(person.ToUpper().StartsWith("T"))
//                {
//                    NewList.Add(person);
//                }
                
//            }
//            NewList.Sort(); 

//            foreach (string person in NewList)
//            {
//                Console.WriteLine(person);  
//            }


//        }

//        public static void Main(string[] args)
//        {
//            //forth do the same as above
//            string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };

           
//            //FIWS
//            //from p in people where p.ToUpper().StartsWith("T") orderby p select p;
//            //LAMBDA
//            //where((p=>p.ToUpper().StartsWith("T")) orderby(p=>p);

//            //create IEnumerable
//            //using LINQ FIWS
//            IEnumerable<string> newlist3 = from p in people where p.ToUpper().StartsWith("T") orderby p select p ;
//            //using LINQ LAMBDA
//            var newlist4 = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);
       
            

//            //convert IEnumerable to list/array
//            string[] newarray1 = newlist3.ToArray();
//            var newarray2= newlist3.ToArray();
//            List<string> newList1 = newlist3.ToList();
//            var newlist2= newlist3.ToList();


//            //create int using LINQ
//            int number = (from p in people where p.ToUpper().StartsWith("T") select p).Count();
//            Console.WriteLine(number);

//            // create IEnumerable using method Enumerable
//            IEnumerable<int> values1 = Enumerable.Range(1, 10);


//        }

//    }
//}

