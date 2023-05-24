//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns
//{
//    internal class abstract_vs_interface
//    {
//        public static void Main()
//        {
//            //Dog dog = new Dog();
//            //dog = (Dog)Attempt();
//            //Console.WriteLine(dog.Name);

//            Worker worker = new Worker();
//            worker = (Worker)Attempt();
//            Console.WriteLine(worker.Name);

//        }

//        public static ICreature Attempt()
//        {
//            Worker worker = new Worker();
//            worker.Name = "Mark";

//            Dog dog = new Dog();
//            dog.Name = "JaJa";

//            return worker;
//        }

//    }

//    public abstract class Animal : ICreature
//    {
//        public string Name { get; set; }

//    }

//    public class Dog : Animal
//    {

//    }



//    public abstract class Person : ICreature
//    {
//        public string Name { get; set; }

//    }

//    public class Worker : Person
//    {

//    }


//    interface ICreature
//    {


//    }



//}
