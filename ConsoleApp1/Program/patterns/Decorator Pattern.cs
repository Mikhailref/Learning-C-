//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    public interface IShape
//    {
//        void Draw();
//    }

//    public class Circle : IShape
//    {
//        public void Draw()
//        {
//            Console.WriteLine("Drawing Circle");
//        }
//    }

//    //ABSTRACT CLASS
//    public abstract class ShapeDecorator : IShape
//    {
//        protected IShape decoratedShape;

//        public ShapeDecorator(IShape decoratedShape)
//        {
//            this.decoratedShape = decoratedShape;
//        }

//        public virtual void Draw()
//        {
//            decoratedShape.Draw();
//        }
//    }

//    public class RedShapeDecorator : ShapeDecorator
//    {
//        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape)
//        {
//        }

//        public override void Draw()
//        {
//            decoratedShape.Draw();
//            SetRedBorder(decoratedShape);
//        }

//        private void SetRedBorder(IShape decoratedShape)
//        {
//            Console.WriteLine("Border Color: Red");
//        }
//    }

//    public class BackGroundShapeDecorator : ShapeDecorator
//    {
//        public BackGroundShapeDecorator(IShape decoratedShape) : base(decoratedShape)
//        {
//        }

//        public override void Draw()
//        {
//            decoratedShape.Draw();
//            SetBlackBackGround(decoratedShape);
//        }

//        private void SetBlackBackGround(IShape decoratedShape)
//        {
//            Console.WriteLine("BackGround: Black");
//        }
//    }



//    public class Programm
//    {
//        public static void Main(string[] args)
//        {
//            IShape circle = new Circle();
//            circle.Draw();

//            IShape redCircle = new RedShapeDecorator(new Circle());
//            redCircle.Draw();

//            IShape blackBackGround = new BackGroundShapeDecorator(new RedShapeDecorator(circle));
//            blackBackGround.Draw();

//            Console.WriteLine("------------------------------");

//            IShape circle2 = new Circle();

//            IShape redCircle2 = new RedShapeDecorator(circle2);
//            redCircle2.Draw();

//            IShape blackBackGround2 = new BackGroundShapeDecorator(redCircle2);
//            blackBackGround2.Draw();

//            Console.WriteLine("------------------------------");
//            IShape circle3 = new RedShapeDecorator(new BackGroundShapeDecorator(new Circle()));
//            circle3.Draw();
//        }

//    }



//}
