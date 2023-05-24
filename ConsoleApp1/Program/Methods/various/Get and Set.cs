//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    internal class Object
//    {
//        private double _num;

//        public double Num
//        {
//            get
//            {
//                return _num * 5;
//            }

//            set
//            {
//                if (value < 0)
//                    throw new ArgumentException("not valid");
//                _num = value;
//            }
//        }

//        public Object(double num)
//        {
//            Num = num;
//            Console.WriteLine(Num);
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            try
//            {
//                Object obj = new Object(-10);
//            }

//            catch (ArgumentException ex)
//            {
//                Console.WriteLine(ex.Message); // Outputs "not valid"
//            }


//            MyClass myClass = new MyClass();
//            myClass.set_num(-10);
//            Console.WriteLine(myClass.get_num());


//            MyClass2 myClass2 = new MyClass2();
//            myClass2.Set_Num(-20);
//            Console.WriteLine(myClass2.Num);


//        }
//    }





//    ////or you can do it explicitly
//    public class MyClass
//    {
//        private double _num;

//        public double get_num()
//        {
//            // Add logic to the getter method
//            return _num * 5;
//        }

//        public void set_num(double value)
//        {
//            // Add logic to the setter method
//            if (value < 0)
//            {
//                // Throw an exception if the value is negative
//                throw new ArgumentException("Value cannot be negative.");
//            }
//            _num = value;
//        }

//    }


//    ////or this way
//    public class MyClass2
//    {
//        public double Num
//        {
//            get; private set;
//        }

//        public void Set_Num(int value)
//        {
//            // Add logic to the setter method
//            if (value < 0)
//            {
//                // Throw an exception if the value is negative
//                throw new ArgumentException("Value cannot be negative.");
//            }
//            Num = value;
//        }
//    }





//    ////the following way is not good
//    /////In this example, we are using the MyProperty property itself 
//    ////to store the value of the property, rather than defining a separate 
//    ////private field. However, this creates an infinite recursion problem in the current implementation, 
//    ////because the getter and setter methods call each other recursively.
//    ////to amend this add private int as in the example of the OBJECT CLASS
//    public class MyClass3
//    {
//         public int Number
        //{
        //    get
        //    {
        //        // Add logic to the getter method
        //        // Here we are just returning the value of the property directly
        //        return Number;
        //    }
        //    set
        //    {
        //        // Add logic to the setter method
        //        if (value < 0)
        //        {
        //            // Throw an exception if the value is negative
        //            throw new ArgumentException("Value cannot be negative.");
        //        }
        //        // Here we are assigning the value directly to the property
        //        Number = value;
        //    }
        //}
//        }
//    }

//}
