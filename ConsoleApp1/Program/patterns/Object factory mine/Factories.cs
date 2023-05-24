//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns.NewFolder
//{

////Factory МЫ БУДЕМ ИСПОЛЬЗОВАТЬ ДЛЯ СОЗДАНИЯ ОБЬЕКТОВ - ХОТЯ МОЖНО И ТУДА ДОБАВИТЬ МЕТОДЫ


//    public interface IFactory
//    {
//        public IShape CreateShape(string shapeType, double param);
//    }

//    //public abstract class Factory
//    //{
//    //    public abstract IShape CreateShape(string shapeType, double param);
//    //}


//    public class FirstFactory : IFactory
//    {
//        public IShape CreateShape(string shapeType, double param)
//        {
//            switch (shapeType)
//            {
//                case "rectangle":
//                    return new Rectangle { width = param, height = param / 2 };

//                case "romb":
//                    return new Romb { width = param, height = param / 2 };
//                default:
//                    throw new ArgumentException("Invalid shape type");
//            }
//        }

//    }

//    public class SecondFactory : IFactory
//    {
//        public IShape CreateShape(string shapeType, double param)
//        {
//            switch (shapeType)
//            {
//                case "circle":
//                    return new Circle { radius = param };
//                default:
//                    throw new ArgumentException("Invalid shape type");
//            }
//        }


//    }








//}
