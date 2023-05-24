//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    internal class Field_vs_Property
//    {

//        public static void Main()
//        {
//            Person person = new Person();
//            person.FirstName = "Mark";
//            //person.SecondName = "Lurif";
//            Console.WriteLine(person.SecondName);
//            Adress = "russia";
//            Console.WriteLine(Adress);
//        }


//        private static string Adress { get; set; } = "holon";
//        //can be used only inside the class
//        //and if you remove SET, you will not be able to reasign it


//    }
//    public class Person
//    {
//        public string FirstName;

//        public string Profession { get; set; }
//        //will create a private string behind the scenes

//        //the empty constractor is also created for any class



//        private string _secondName ="Gelberg"; // Private field
//        public string SecondName
//        { // Property
//            get { return _secondName; }
//            set
//            {
//                if (value.Length < 2)
//                    throw new ArgumentException("Name must be at least 2 characters long.");
//                _secondName = value;
//            }
//        }
//        //property allows us to get or set private field




//    }
//}
