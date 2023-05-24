//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{

//    ////https://www.youtube.com/watch?v=NU_1StN5Tkk&t=849s
//    /// <summary>
//    /// POLYMORFISM means many forms, in this example function DRAW
//    /// is used in various forms meaning it make different things
//    /// depending on the class that calls it
//    /// </summary>
//    public interface IInterface
//    {
//        public void Draw();
//    }

//    internal class Circle : IInterface
//    {
//        public void Draw()
//        {
//            Console.WriteLine("Draw a Circle");
//        }
//    }

//    internal class Rectangle : IInterface
//    {
//        public void Draw()
//        {
//            Console.WriteLine("Draw a Rectangle");
//        }
//    }

//    internal class Programm
//    {
//        public static void Main()
//        {
//            Function(new Rectangle());
//        }
//        public static void Function(IInterface Object)
//        {
//            Object.Draw();
//        }
//    }

//    public class Romb : IInterface
//    {
//        public void Draw()
//        {
//            throw new System.NotImplementedException();
//        }
//    }
//}
