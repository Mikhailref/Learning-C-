//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    public interface Visitor
//    {
//        void Visit(Circle circle);
//        void Visit(Square square);

//    }

//    public class AreaVisitor : Visitor
//    {
//        public void Visit(Circle circle)
//        {
//            double area = Math.PI * Math.Pow(circle.Radius, 2);
//            Console.WriteLine("Area of circle with radius {0} is {1}", circle.Radius, area);
//        }

//        public void Visit(Square square)
//        {
//            double area = Math.Pow(square.SideLength, 2);
//            Console.WriteLine("Area of square with side length {0} is {1}", square.SideLength, area);
//        }


//    }

//    public class PerimeterVisitor : Visitor
//    {
//        public void Visit(Circle circle)
//        {
//            double perimeter = 2 * Math.PI * circle.Radius;
//            Console.WriteLine("Perimeter of circle with radius {0} is {1}", circle.Radius, perimeter);
//        }

//        public void Visit(Square square)
//        {
//            double perimeter = 4 * square.SideLength;
//            Console.WriteLine("Perimeter of square with side length {0} is {1}", square.SideLength, perimeter);
//        }
//    }



//    public interface Shape
//    {
//        void Accept(Visitor visitor);
//    }

//    public class Circle : Shape
//    {
//        public double Radius { get; set; }

//        public void Accept(Visitor visitor)
//        {
//            visitor.Visit(this);
//        }
//    }

//    public class Square : Shape
//    {
//        public double SideLength { get; set; }

//        public void Accept(Visitor visitor)
//        {
//            visitor.Visit(this);
//        }
//    }



//    public class Programm
//    {
//        public static void Main()
//        {
//            var circle = new Circle { Radius = 5 };
//            var square = new Square { SideLength = 10 };


//            AreaVisitor areaVisitor = new AreaVisitor();
//            circle.Accept(areaVisitor);
//            square.Accept(areaVisitor);

//            PerimeterVisitor perimeterVisitor = new PerimeterVisitor();
//            circle.Accept(perimeterVisitor);
//            square.Accept(perimeterVisitor);

//        }
//    }









//}
