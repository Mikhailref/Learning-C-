//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static ConsoleApp1.Program.YouTube.Polymorphism__Dependency_Injection__Factory;

//namespace ConsoleApp1.Program.YouTube
//{
//    internal class Polymorphism__Dependency_Injection__Factory
//    {
//        public static void Main()
//        {
//            //Person
//            //Pen-writing
//            //Shoes-walking

//            //Factory МЫ БУДЕМ ИСПОЛЬЗОВАТЬ ДЛЯ СОЗДАНИЯ ОБЬЕКТОВ - ХОТЯ МОЖНО И ТУДА ДОБАВИТЬ МЕТОДЫ

//            Person person = new Person(new Pen());
//            person.Ability();


//            // МЫ МОЖЕМ ЗАПИХАТЬ DEPENDENCY INJECTION В ОБЬЕКТ КАК ЗДЕСЬ ИЛИ ПРОСТО В ФУНКЦИЮ

//            Function(new Pen());

//        }

//        //КАК ВАРИАНТ СОЗДАДИМ ФУНКЦИЮ И ПЕРЕДАДИМ ИТЕРФЕЙС

//        public static void Function(ITool tool)
//        {
//            tool.Doing();
//        }
//    }


//    public class Person
//    {
//        private ITool _tool;
//        public Person(ITool tool)
//        {
//            _tool = tool;
//        }

//        public void Ability()
//        {
//            _tool.Doing();
//        }

//    }

//    public interface ITool
//    {
//        void Doing();
//    }


//    public class Pen : ITool
//    {
//        public Pen()
//        {

//        }
//        public void Doing()
//        {
//            Console.WriteLine("Writing");
//        }

//    }

//    public class Shoes : ITool
//    {
//        public Shoes()
//        {

//        }
//        public void Doing()
//        {
//            Console.WriteLine("Walking");
//        }
//    }
//}








