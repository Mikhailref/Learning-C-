//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns
//{

//    //The singleton pattern is a design pattern that ensures a class has
//    //only one instance, while providing a global access point to this
//    //instance. In C#, a singleton class can be implemented by declaring
//    //its constructor as private, and providing a static property or method
//    //that returns the single instance of the class. This instance can be created
//    //the first time it is accessed, or it can be created at application startup
//    //and held in a static variable.

//    //In this example, the Singleton class's constructor is declared as private,
//    //so it cannot be instantiated directly. Instead, clients can use the static Instance
//    //property to get the single instance of the class.
//    //The first time the Instance property is accessed, a new Singleton object is created
//    //and stored in the instance variable. On subsequent accesses, the same instance
//    //stored in instance is returned.


//    //public class Program
//    //{
//    //    public static void Main()
//    //    {
//    //        Singleton.Instance.DoSomething();
//    //    }
//    //}

//    //public class Singleton
//    //{
//    //    private static Singleton instance;

//    //    private Singleton() { }

//    //    public static Singleton Instance
//    //    {
//    //        get
//    //        {
//    //            if (instance == null)
//    //            {
//    //                instance = new Singleton();
//    //            }
//    //            return instance;
//    //        }
//    //    }

//    //    public void DoSomething()
//    //    {
//    //        Console.WriteLine("Doing something...");
//    //    }
//    //}

//    //Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует, что для
//    //определенного класса будет создан только один объект, а также предоставит к этому объекту точку доступа.

//    //Когда надо использовать Синглтон? Когда необходимо, чтобы для класса существовал только один экземпляр

//    //Синглтон позволяет создать объект только при его необходимости.Если объект не нужен,
//    //то он не будет создан.В этом отличие синглтона от глобальных переменных.





////Для применения паттерна Одиночка создадим небольшую программу. Например, на каждом компьютере можно
////одномоментно запустить только одну операционную систему.
////В этом плане операционная система будет реализоваться через паттерн синглтон:

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Computer comp = new Computer();
////            comp.Launch("Windows 8.1");
////            Console.WriteLine(comp.OS.Name);

////            // у нас не получится изменить ОС, так как объект уже создан    
////            comp.OS = OS.getInstance("Windows 10");
////            Console.WriteLine(comp.OS.Name);

////            //и даже так у нас будет только WIDOWS 8.1
////            Computer comp2 = new Computer();
////            comp2.Launch("Windows 10");
////            Console.WriteLine(comp2.OS.Name);

////        }
////    }
////    class Computer
////    {
////        public OS OS { get; set; }
////        public void Launch(string osName)
////        {
////            OS = OS.getInstance(osName);
////        }
////    }
////    class OS
////    {
////        private static OS instance;

////        public string Name { get; private set; }

////        protected OS(string name)
////        {
////            this.Name = name;
////        }

////        public static OS getInstance(string name)
////        {
////            if (instance == null)
////                instance = new OS(name);
////            return instance;
////        }
////    }
//}
