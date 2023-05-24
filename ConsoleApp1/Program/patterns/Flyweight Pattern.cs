//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    public interface IShape
//    {
//        void Draw();
//    }

//    public class Circle : IShape
//    {
//        private int _radius;

//        public Circle(int radius)
//        {
//            _radius = radius;
//        }

//        public void Draw()
//        {
//            Console.WriteLine($"Drawing a circle with radius {_radius}");
//        }
//    }

//    public class ShapeFactory
//    {
//        private Dictionary<int, IShape> _shapes = new Dictionary<int, IShape>();

//        public IShape GetShape(int radius)
//        {
//            // Check if a circle with the given radius already exists
//            if (!_shapes.TryGetValue(radius, out IShape shape))
//            {
//                // If not, create a new circle and add it to the dictionary
//                shape = new Circle(radius);
//                _shapes.Add(radius, shape);
//            }

//            return shape;
//        }
//    }

//    public class Programm
//    {
//        static void Main(string[] args)
//        {
//            ShapeFactory factory = new ShapeFactory();

//            // Get a circle with radius 5
//            IShape circle1 = factory.GetShape(5);
//            circle1.Draw();

//            // Get another circle with radius 5
//            IShape circle2 = factory.GetShape(5);
//            circle2.Draw();

//            // The two circles are the same object, even though we got them from separate calls to the factory
//            Console.WriteLine(circle1 == circle2); // Output: True
//        }
//    }
//}
