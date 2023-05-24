//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////reference https://metanit.com/sharp/patterns/2.1.php

//namespace ConsoleApp1.CodeWars._40_50
//{

///////Factory МЫ БУДЕМ ИСПОЛЬЗОВАТЬ ДЛЯ СОЗДАНИЯ ОБЬЕКТОВ - ХОТЯ МОЖНО И ТУДА ДОБАВИТЬ МЕТОДЫ

//    class Program
//    {
//        static void Main(string[] args)
//        {

//            Developer developer = new PanelDeveloper("builder1");
//            House house1 = developer.Create();

//            developer = new WoodDeveloper("builder2");
//            House house2 = developer.Create();

//            developer = new BreakDeveloper("builder3");
//            House house3= developer.Create();



//            //another example
//            IAnimals animal = AnimalFactory.GetAnimal("dog");
//            animal.Speak(); // Output: Woof!

//            animal = AnimalFactory.GetAnimal("cat");
//            animal.Speak(); // Output: Meow!


//            //another one
//            IShape shape = ShapeFactory.CreateShape("rectangle", 4.0);
//            Console.WriteLine(shape.GetArea()); // Output: 4

//            shape = ShapeFactory.CreateShape("circle", 2.0);
//            Console.WriteLine(shape.GetArea()); // Output:  approx. 12.57


//        }
//    }

//    // абстрактный класс строительной компании
//    abstract class Developer
//    {
//        public string Name { get; set; }

//        public Developer(string n)
//        {
//            Name = n;
//        }
//        // фабричный метод
//        abstract public House Create();
//    }


//    // строит панельные дома
//    class PanelDeveloper : Developer
//    {
//        public PanelDeveloper(string n) : base(n)
//        { 

//        }

//        public override House Create()
//        {
//            return new PanelHouse();
//        }
//    }

//    // строит деревянные дома
//    class WoodDeveloper : Developer
//    {
//        public WoodDeveloper(string n) : base(n)
//        { }

//        public override House Create()
//        {
//            return new WoodHouse();
//        }
//    }


//    // строит кирпичные дома
//    class BreakDeveloper : Developer
//    {
//        public BreakDeveloper(string n) : base(n)
//        { }

//        public override House Create()
//        {
//            return new BreakHouse();
//        }
//    }






//    abstract class House
//    { 

//    }

//    class PanelHouse : House
//    {
//        public PanelHouse()
//        {
//            Console.WriteLine("panel house is built");
//        }
//    }
//    class WoodHouse : House
//    {
//        public WoodHouse()
//        {
//            Console.WriteLine("wooden house is built");
//        }
//    }

//    class BreakHouse : House
//    {
//        public BreakHouse()
//        {
//            Console.WriteLine("Break house is built");
//        }
//    }



//    //another example

//    //In this example, the factory class AnimalFactory
//    //creates objects of type IAnimals, which could be
//    //either a Dog or a Cat class. The factory method
//    //GetAnimals(string animalType) takes a string as
//    //an argument and return the respective animal class object.

//    //This allows for a flexible way
//    //to create objects without having
//    //to know the exact class at compile time
//    //and also encapsulates the object creation
//    //process in a separate class.

//    internal interface IAnimals
//    {
//        void Speak();
//    }

//    class Dog : IAnimals
//    {
//        public void Speak()
//        {
//            Console.WriteLine("Woof!");
//        }
//    }



//    class Cat : IAnimals
//    {
//        public void Speak()
//        {
//            Console.WriteLine("Meow!");
//        }
//    }

//    class AnimalFactory
//    {
//        public static IAnimals GetAnimal(string animalType)
//        {
//            switch (animalType)
//            {
//                case "dog":
//                    return new Dog();
//                case "cat":
//                    return new Cat();
//                default:
//                    throw new ArgumentException("Invalid animal type");
//            }
//        }
//    }



//    //another one

//    //In this example, the factory class ShapeFactory creates objects of type IShape, which could be either a Rectangle or a Circle class. The factory method CreateShape(string shapeType, double param) takes a string and a double as an argument and creates the shape object with the respective parameters.

//    //This factory method allows you to create different shapes based on the input parameters, without having to know the exact class at compile time, and also encapsulates the object creation process in a separate class.
//    interface IShape
//    {
//        double GetArea();
//    }

//    class Rectangle : IShape
//    {
//        public double width { get; set; }
//        public double height { get; set; }

//        public double GetArea()
//        {
//            return width * height;
//        }
//    }

//    class Circle : IShape
//    {
//        public double radius { get; set; }

//        public double GetArea()
//        {
//            return Math.PI * radius * radius;
//        }
//    }

//    class ShapeFactory
//    {
//        public static IShape CreateShape(string shapeType, double param)
//        {
//            switch (shapeType)
//            {
//                case "rectangle":
//                    return new Rectangle { width = param, height = param / 2 };
//                case "circle":
//                    return new Circle { radius = param };
//                default:
//                    throw new ArgumentException("Invalid shape type");
//            }
//        }
//    }

//}
