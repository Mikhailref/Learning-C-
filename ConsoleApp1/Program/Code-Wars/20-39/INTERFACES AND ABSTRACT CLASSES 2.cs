//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////INTERFACES AND ABSTRACT CLASSES
////https://www.youtube.com/watch?v=jh4y8HzGqCQ
////USING INTERFACE IS BETTER THE USING ABSTRACT CLASSES
////BUT WE CAN NOT ADD LOGIC TO INTERFACE'S METHODS
////BUT WE CAN NOT ADD LOGIC TO THE ABSTRACT METHOD IETHER
////


//namespace ConsoleApp1.CodeWars
//{
//    public abstract class Machine
//    {
//        abstract public bool Start();

//        abstract public bool Stop();

//    }
//    public class Car : Machine
//    {


//        public override bool Start()
//        {
//            Console.WriteLine("Started");
//            return true;
//        }

//        public override bool Stop()
//        {
//            Console.WriteLine("Stoped");
//            return true;
//        }
//    }


//    public class Bike : Machine
//    {
//        public override bool Start()
//        {
//            Console.WriteLine("Started");
//            return true;
//        }

//        public override bool Stop()
//        {
//            Console.WriteLine("Stoped");
//            return true;
//        }
//    }

//    public class Programm
//    {
//        static void Main()
//        {
//            Car car = new Car();
//            car.Start();

//            Bike bike = new Bike();
//            bike.Start();

//        }
//    }



//}

