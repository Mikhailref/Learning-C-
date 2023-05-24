//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns.NewFolder
//{
//    internal class MainClass
//    {
//        public static void Main()
//        {

//            //WITHOUT INHERITANCE
//            //in Factories it looks like that
//            //use static classes and methods in Factories

//            //IShape shape = FirstFactory.CreateShape("rectangle", 4.0);
//            //Console.WriteLine(shape.GetArea());

//            //shape = FirstFactory.CreateShape("romb", 6.0);
//            //Console.WriteLine(shape.GetArea());

//            //shape = SecondFactory.CreateShape("circle", 2.0);
//            //Console.WriteLine(shape.GetArea());


//            //Have to add object dependensy so as to swap FirstFactory with the SecondFactory



//            //WITH INHERITANCE FROM INTERFACE
//            //in factories it looks like that
//            //Do not use static classes and methods in Factories

//            IFactory factory = new FirstFactory();
//            IShape rectangle = factory.CreateShape("rectangle", 4.0);
//            Console.WriteLine(rectangle.GetArea());

//            IShape romb = factory.CreateShape("romb", 6.0);
//            Console.WriteLine(romb.GetArea());

//            factory = new SecondFactory();
//            IShape circle = factory.CreateShape("circle", 2.0);
//            Console.WriteLine(circle.GetArea());

//            //Have to add object dependensy so as to swap FirstFactory with the SecondFactory





//        }

//    }
//}
