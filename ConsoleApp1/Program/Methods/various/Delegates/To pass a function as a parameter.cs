//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.Methods.various.Delegates.Delegate
//{

//    /// <summary>
//    /// https://www.youtube.com/watch?v=uAhVpw8zzm4
//    /// </summary>
//    internal class To_pass_function_as_a_parameter
//    {
//        //допустим у нас есть стандартная функция мы можем ее вызвать
//        static void PrintFunction(string text)
//        {
//            Console.WriteLine(text + " function");
//        }


//        //но что если мы хотим ее передать как параметр в другую функцию
//        //static void PrintMethod(Print(string text))

//        //это будет выглядеть вот так
//        //нам нужна функция которая принимает делегаты 
//        static void PrintMethod(Delegate printDelegate)
//        {
//            //и вызываем по принципу
//            //PrintFunction("just text")
//            printDelegate("hello,");
//            printDelegate("How are you ?");
//        }

//        //нам нужен универсальный делегат с signature void(string)
//        delegate void Delegate(string text);

//        //создадим от него функции с той же signature
//        //которые по принципу равны static void Print(string text)
//        static Delegate PrintText = (string text) =>
//        {
//            Console.WriteLine(text + " from a delegate");
//        };

//        static Delegate PrintAnotherText = (string text) =>
//        {
//            Console.WriteLine(text + " from another delegate");
//        };


//        //THE OTHER WAYS TO WRITE DELEGATE FUNCIONS

//        //static void PrintAnotherTextMethod(string text)
//        //{
//        //    Console.WriteLine(text + " from another delegate");
//        //}

//        //static Delegate PrintAnotherText = new Delegate(PrintAnotherTextMethod);


//        //static void PrintAnotherTextMethod(string text)
//        //{
//        //    Console.WriteLine(text + " from another delegate");
//        //}

//        //static Delegate PrintAnotherText = new Delegate(PrintAnotherTextMethod);


//        //static Action<string> PrintAnotherText = (text) =>
//        //{
//        //    Console.WriteLine(text + " from another delegate");
//        //};


//        public static void Main()
//        {
//            PrintFunction("I am a standart ");

//            //и теперь мы можем передать наши делегаты PrintText и PrintAnotherText в другую функций 
//            //PrintMethod(Delegate printDelegate);

//            PrintMethod(PrintText);
//            PrintMethod(PrintAnotherText);


//            //to pass an object as a parameter
//            Class @class = new Class();
//            Attempt attempt = new Attempt();
//            attempt.Try(@class);

//        }

//        public interface Interface
//        {
//            void Method();
//        }

//        public class Class : Interface
//        {
//            public void Method()
//            {
//                Console.WriteLine("hello i am the interface");
//            }
//        }

//        public class Attempt
//        {
//            public void Try(Interface @interface)
//            {
//                @interface.Method();
//            }
//        }



//    }
//}
