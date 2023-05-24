//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns
//{

//    //In C#, a pattern is a reusable solution to a common problem in software design. Some common design patterns in C# include the following:

//    //Singleton pattern: This pattern ensures that a class has only one instance and provides a global point of access to it.

//    //Factory pattern: This pattern provides a way to create objects without specifying the exact class of object that will be created.

//    //Observer pattern: This pattern allows objects to be notified of changes to other objects without having tight coupling between them.

//    //Decorator pattern: This pattern allows behavior to be added to an individual object, either statically or dynamically, without affecting the behavior of other objects from the same class.

//    //Command pattern: This pattern encapsulates a request as an object, allowing it to be handled in a generic way.

//    //To use a pattern in a C# program, you would define a class or set of classes that implement the pattern, and then use those classes in your program where the pattern is needed. It's important to understand the problem and context the pattern is trying to solve before implementing it in your code.




//    // Singelton pattern:
//    public class Singleton
//    {
//        private static Singleton instance;
//        private Singleton() { }
//        public static Singleton Instance
//        {
//            get
//            {
//                if (instance == null)
//                {
//                    instance = new Singleton();
//                }
//                return instance;
//            }
//        }
//    }

//    //Singleton pattern:
//    Singleton singleton = Singleton.Instance;



//    // Factory pattern:

//    public abstract class Vehicle
//    {
//        public abstract string GetType();
//    }

//    public class Car : Vehicle
//    {
//        public override string GetType()
//        {
//            return "Car";
//        }
//    }

//    public class Truck : Vehicle
//    {
//        public override string GetType()
//        {
//            return "Truck";
//        }
//    }

//    public class VehicleFactory
//    {
//        public Vehicle GetVehicle(string type)
//        {
//            if (type == "Car")
//            {
//                return new Car();
//            }
//            else if (type == "Truck")
//            {
//                return new Truck();
//            }
//            else
//            {
//                return null;
//            }
//        }
//    }

//    //Factory pattern:
//    VehicleFactory factory = new VehicleFactory();
//    Vehicle car = factory.GetVehicle("Car");
//    Vehicle truck = factory.GetVehicle("Truck");



//    //Observer pattern:

//    public interface IObserver
//    {
//        void Update(string message);
//    }

//    public interface ISubject
//    {
//        void Register(IObserver observer);
//        void Unregister(IObserver observer);
//        void Notify();
//    }

//    public class Observer : IObserver
//    {
//        public void Update(string message)
//        {
//            // Handle update
//        }
//    }

//    public class Subject : ISubject
//    {
//        private List<IObserver> observers = new List<IObserver>();
//        public void Register(IObserver observer)
//        {
//            observers.Add(observer);
//        }
//        public void Unregister(IObserver observer)
//        {
//            observers.Remove(observer);
//        }
//        public void Notify()
//        {
//            foreach (var observer in observers)
//            {
//                observer.Update("Notification message");
//            }
//        }
//    }

//    // Observer pattern:
//    Observer observer = new Observer();
//    Subject subject = new Subject();
//    subject.Register(observer);
//    subject.Notify();




//    //Decorator pattern:

//    public interface IComponent
//    {
//        string Operation();
//    }

//    public class Component : IComponent
//    {
//        public string Operation()
//        {
//            return "I am walking ";
//        }
//    }

//    public class DecoratorA : IComponent
//    {
//        IComponent component;
//        public DecoratorA(IComponent c)
//        {
//            component = c;
//        }
//        public string Operation()
//        {
//            return component.Operation() + "and listening to Classic FM ";
//        }
//    }

//    public class DecoratorB : IComponent
//    {
//        IComponent component;
//        public string addedState = "past the Coffee Shop ";
//        public DecoratorB(IComponent c)
//        {
//            component = c;
//        }
//        public string Operation()
//        {
//            return component.Operation() + addedState;
//        }
//    }

//    //Decorator pattern:
//    IComponent component = new Component();
//    IComponent decoratorA = new DecoratorA(component);
//    IComponent decoratorB = new DecoratorB(decoratorA);
//    Console.WriteLine(decoratorB.Operation());


//    //Command pattern:

//    public interface ICommand
//    {
//        void Execute();
//    }

//    public class ConcreteCommand :


//    //Command pattern:
//    Receiver receiver = new Receiver();
//    ICommand command = new ConcreteCommand(receiver);
//    Invoker invoker = new Invoker();
//    invoker.SetCommand(command);
//    invoker.ExecuteCommand();


//    internal class overall
//    {

//    }
//}
