//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{

//    // The prototype interface declares a clone method, which is used to create
//    // a copy of an object.
//    public interface IPrototype
//    {
//        IPrototype Clone();
//    }

//    // Concrete prototypes implement the clone method and define the logic for copying
//    // an object. In this example, we will create a concrete prototype for a car.
//    public class Car: IPrototype
//    {
//        public string Brand { get; set; }
//        public string Model { get; set; }
//        public int Year { get; set; }
//        public string Color { get; set; }

//        public Car(string brand, string model, int year, string color)
//        {
//            Brand = brand;
//            Model = model;
//            Year = year;
//            Color = color;
//        }

//        // The clone method creates a new instance of the CarPrototype class and
//        // sets its properties to match the original object.
//        public IPrototype Clone()
//        {
//            return new Car(Brand, Model, Year, Color);
//        }
//    }

//    // The client code can use the prototype to create new objects without
//    // having to know the exact class of the object it needs to create.
//    public class Client
//    {
//        public static  void Main()
//        {
//            // Create a new car prototype.
//            Car Car = new Car("Toyota", "Corolla", 2022, "Red");

//            // Clone the prototype to create a new car object.
//            Car Prototype = (Car)Car.Clone();
//            Car Prototype2 = Car.Clone()as Car;

//            // Output the details of the new car object.
//            Console.WriteLine("Brand: " + Prototype.Brand+Prototype.Model+Prototype.Year+Prototype.Color);
//            Console.WriteLine("Brand: " + Prototype2.Brand+Prototype2.Model+Prototype2.Year+Prototype2.Color);
            
//        }
//    }

//    // The output of the above code should be:
//    // Brand: Toyota
//    // Model: Corolla
//    // Year: 2022
//    // Color: Red

//}
