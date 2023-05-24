//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns
//{


////Factory МЫ БУДЕМ ИСПОЛЬЗОВАТЬ ДЛЯ СОЗДАНИЯ ОБЬЕКТОВ - ХОТЯ МОЖНО И ТУДА ДОБАВИТЬ МЕТОДЫ

//    public interface IHouse
//    {
//        public int Price { get; set; }
//        void Create();
//    }

//    class PanelHouse : IHouse
//    {
//        public int Price { get; set; }

//        public PanelHouse()
//        {

//        }

//        public void Create()
//        {
//            Console.WriteLine("panel house is built");
//        }
//    }
//    class WoodHouse : IHouse
//    {
//        public int Price { get; set; }

//        public WoodHouse()
//        {

//        }
//        public void Create()
//        {
//            Console.WriteLine("wooden house is built");
//        }

//    }


//    static class USAHouseFactory
//    {
//        public static IHouse GetHouse(string HouseType)
//        {
//            switch (HouseType)
//            {
//                case "Panel House":
//                    return new PanelHouse();
//                case "Wood House":
//                    return new WoodHouse();
//                default:
//                    throw new ArgumentException("no valid");
//            }
//        }
//    }


//    static class Program
//    {
//        static void Main(string[] args)
//        {

//            IHouse house = USAHouseFactory.GetHouse("Wood House");
//            house.Create();

//            Console.WriteLine(house.Price);

//            house = USAHouseFactory.GetHouse("Panel House");
//            house.Create();

//            Console.WriteLine(house.Price);



//        }
//    }
//}
