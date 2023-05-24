//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////If you have a client that expects to work
////with only rectangles, but you have a Square
////class that cannot be used directly, which design
////pattern would you use to make Square compatible with
////the client's expectations and ensure that the client
////can use it as if it were a Rectangle?

//namespace ConsoleApp1.Program.patterns.various
//{
//    //we want to use SQUARE in a programm that expects only OBJECTS of type RECTANGLE
//    //so we build a new ClASS wich adapts SQUARES to RECTANGLES


//    // A Shape interface that defines the contract for any shape
//    interface IShape
//    {
//        double CalculateArea();
//    }


//    // A Square class that implements the Shape interface and represents a square
//    class Square : IShape
//    {
//        public readonly double _side;

//        public Square(double side)
//        {
//            _side = side;
//        }

//        // Implementation of the CalculateArea method from the Shape interface
//        public double CalculateArea()
//        {
//            return _side * _side;
//        }
//    }


//    // A Rectangle class that implements the Shape interface and represents a rectangle
//    class Rectangle : IShape
//    {
//        private readonly double _width;
//        private readonly double _height;

//        public Rectangle(double width, double height)
//        {
//            _width = width;
//            _height = height;
//        }

//        // Implementation of the CalculateArea method from the Shape interface
//        public double CalculateArea()
//        {
//            return _width * _height;
//        }
//    }


//    // An Adapter class that adapts a Square object to a Rectangle object
//    class SquareToRectangleAdapter : Rectangle
//    {
//        private readonly Square _square;

//        public SquareToRectangleAdapter(Square square) : base(square._side, square._side)
//        {
//            _square = square;
//        }
//    }

//    class Client
//    {
//        public static void Main()
//        {
//            // Create a Rectangle object and calculate its area
//            Rectangle rectangle = new Rectangle(5.0, 10.0);
//            double areaOfRectangle = rectangle.CalculateArea();
//            Console.WriteLine($"Area of Rectangle: {areaOfRectangle}");


//            //we want to use SQUARE in a programm that expects only OBJECTS of type RECTANGLE
//            //so we build a new ClASS wich adapts SQUARES to RECTANGLES

//            // Create a Square object and adapt it to a Rectangle object using the adapter

//            Square square = new Square(5.0);
//            SquareToRectangleAdapter adapterForSquare = new SquareToRectangleAdapter(square);
//            double areaOfSquare = adapterForSquare.CalculateArea();
//            Console.WriteLine($"Area of Square: {areaOfSquare}");

//        }
//    }

//}
