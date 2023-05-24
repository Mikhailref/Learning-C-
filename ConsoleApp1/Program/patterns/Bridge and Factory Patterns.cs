
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////the factory pattern creates objects.
////the bridge pattern choose the instrument to draw these object
////in this case VectorRendere or RasterRenderer can draw the same object but differently

//namespace ConsoleApp1.Program.YouTube
//{
//    internal class Factory_and_Bridge
//    {
//        public interface IShape
//        {
//            void Draw();
//        }

//        public interface IRenderer
//        {
//            void RenderCircle(int x, int y, int radius);
//            void RenderTriangle(int x1, int y1, int x2, int y2, int x3, int y3);
//        }

//        public class VectorRenderer : IRenderer
//        {
//            public void RenderCircle(int x, int y, int radius)
//            {
//                Console.WriteLine($"Drawing a circle at ({x}, {y}) with radius {radius} using vector graphics");
//            }

//            public void RenderTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
//            {
//                Console.WriteLine($"Drawing a triangle at ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}) using vector graphics");
//            }
//        }

//        public class RasterRenderer : IRenderer
//        {
//            public void RenderCircle(int x, int y, int radius)
//            {
//                Console.WriteLine($"Drawing a circle at ({x}, {y}) with radius {radius} using raster graphics");
//            }

//            public void RenderTriangle(int x1, int y1, int x2, int y2, int x3, int y3)
//            {
//                Console.WriteLine($"Drawing a triangle at ({x1}, {y1}), ({x2}, {y2}), ({x3}, {y3}) using raster graphics");
//            }
//        }



//        public class Circle : IShape
//        {
//            private int _x;
//            private int _y;
//            private int _radius;
//            private IRenderer _renderer;

//            public Circle(int x, int y, int radius, IRenderer renderer)
//            {
//                _x = x;
//                _y = y;
//                _radius = radius;
//                _renderer = renderer;
//            }

//            public void Draw()
//            {
//                _renderer.RenderCircle(_x, _y, _radius);
//            }
//        }

//        public class Triangle : IShape
//        {
//            private int _x1;
//            private int _y1;
//            private int _x2;
//            private int _y2;
//            private int _x3;
//            private int _y3;
//            private IRenderer _renderer;

//            public Triangle(int x1, int y1, int x2, int y2, int x3, int y3, IRenderer renderer)
//            {
//                _x1 = x1;
//                _y1 = y1;
//                _x2 = x2;
//                _y2 = y2;
//                _x3 = x3;
//                _y3 = y3;
//                _renderer = renderer;
//            }

//            public void Draw()
//            {
//                _renderer.RenderTriangle(_x1, _y1, _x2, _y2, _x3, _y3);
//            }
//        }

//        public class ShapeFactory
//        {
//            public IShape CreateCircle(int x, int y, int radius, bool useVectorGraphics)
//            {
//                IRenderer renderer = useVectorGraphics ? new VectorRenderer() : new RasterRenderer();
//                return new Circle(x, y, radius, renderer);
//            }

//            public IShape CreateTriangle(int x1, int y1, int x2, int y2, int x3, int y3, bool useVectorGraphics)
//            {
//                IRenderer renderer = useVectorGraphics ? new VectorRenderer() : new RasterRenderer();
//                return new Triangle(x1, y1, x2, y2, x3, y3, renderer);
//            }
//        }

//        public class Programm
//        {
//            public static void Main()
//            {
//                ShapeFactory shapeFactory = new ShapeFactory();
//                IShape Circle = shapeFactory.CreateCircle(10,10,30,false);
//                Circle.Draw();
//                IShape Triangle = shapeFactory.CreateTriangle(10, 10, 10, 10, 10, 10, true);
//                Triangle.Draw();

//                //the factory pattern creates objects.
//                //the bridge pattern choose the instrument to draw these object
//                //in this case VectorRendere or RasterRenderer can draw the same object but differently

//            }


//        }



//    }
//}
