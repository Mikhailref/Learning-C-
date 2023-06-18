//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    // Abstraction
//    public abstract class Shape
//    {
//        protected IRenderer renderer;

//        public Shape(IRenderer renderer)
//        {
//            this.renderer = renderer;
//        }

//        public abstract void Draw();
//    }

//    // Implementor
//    public interface IRenderer
//    {
//        void RenderCircle(float radius);
//        void RenderTriangle(float baseLength, float height);
//    }

//    // Concrete Implementor
//    public class VectorRenderer : IRenderer
//    {
//        public void RenderCircle(float radius)
//        {
//            Console.WriteLine($"Drawing a circle with radius {radius} using VectorRenderer");
//        }

//        public void RenderTriangle(float baseLength, float height)
//        {
//            Console.WriteLine($"Drawing a triangle with base {baseLength} and height {height} using VectorRenderer");
//        }
//    }

//    // Concrete Implementor
//    public class RasterRenderer : IRenderer
//    {
//        public void RenderCircle(float radius)
//        {
//            Console.WriteLine($"Drawing a circle with radius {radius} using RasterRenderer");
//        }

//        public void RenderTriangle(float baseLength, float height)
//        {
//            Console.WriteLine($"Drawing a triangle with base {baseLength} and height {height} using RasterRenderer");
//        }
//    }

//    // Refined Abstraction
//    public class Circle : Shape
//    {
//        private float radius;

//        public Circle(float radius, IRenderer renderer) : base(renderer)
//        {
//            this.radius = radius;
//        }

//        public override void Draw()
//        {
//            renderer.RenderCircle(radius);
//        }
//    }

//    // Refined Abstraction
//    public class Triangle : Shape
//    {
//        private float baseLength;
//        private float height;

//        public Triangle(float baseLength, float height, IRenderer renderer) : base(renderer)
//        {
//            this.baseLength = baseLength;
//            this.height = height;
//        }

//        public override void Draw()
//        {
//            renderer.RenderTriangle(baseLength, height);
//        }
//    }

//    // Usage
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var vectorRenderer = new VectorRenderer();

//            var circle = new Circle(5, vectorRenderer);
//            circle.Draw(); // Output: Drawing a circle with radius 5 using VectorRenderer

//            var triangle = new Triangle(10, 15, vectorRenderer);
//            triangle.Draw(); // Output: Drawing a triangle with base 10 and height 15 using VectorRenderer

//            var rasterRenderer = new RasterRenderer();

//            var circle2 = new Circle(10, rasterRenderer);
//            circle2.Draw(); // Output: Drawing a circle with radius 10 using RasterRenderer

//            var triangle2 = new Triangle(20, 25, rasterRenderer);
//            triangle2.Draw(); // Output: Drawing a triangle with base 20 and height 25 using RasterRenderer
//        }
//    }

//}
