//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Reflection.Metadata.Ecma335;
//using System.Text;
//using System.Threading.Tasks;


//namespace ConsoleApp1.Program.YouTube.Various
//{
//    public class Three_arguments_to_pass
//    {
//        //passing primitive or compound, as well as complex data types and methods as parameters to the functions

//        public static void aSimpleFunction(string text)
//        {
//            Console.WriteLine("hello i am the " + text);
//        }

//        //passing a class
//        public interface IMachine
//        {
//            void Drive();
//        }

//        public class Car : IMachine
//        {
//            public void Drive()
//            {
//                Console.WriteLine("I am a car");
//            }
//        }

//        public class Transport
//        {
//            public void PublicTransport(IMachine machine)
//            {
//                machine.Drive();
//            }
//        }

//        //the main function
//        public static void Main()
//        {
//            aSimpleFunction("primitive data type");

//            Car car = new Car();
//            Transport transport = new Transport();
//            transport.PublicTransport(car);

//            //the first and the second option
//            FunctionToPass(PrintText);
//            FunctionToPass(PrintAnotherText);


//            //the third and fourth options
//            PrintTextAgain.Invoke("Hello, world!"); // using the Invoke method

//            PrintTextAgainAndAgain("Hello again, world!"); // using the delegate as a method call



//        }

//        //the first option
//        static void FunctionToPass(Delegate delegateFunction)
//        {
//            delegateFunction("hello I am a delegate");
//        }

//        delegate void Delegate(string text);

//        static Delegate PrintText = (string text) =>
//        {
//            Console.WriteLine(text);
//        };


//        //the second option
//        private static void FunctionToPass(Action<string> printAnotherText)
//        {
//            printAnotherText("helolol");
//        }

//        static Action<string> PrintAnotherText = (text) =>
//        {
//            Console.WriteLine(text + " from another delegate");
//        };



//        //the third option
//        static void Method(string text)
//        {
//            Console.WriteLine(text);
//        }

//        static Delegate PrintTextAgain = new Delegate(Method);


//        //the fourth option
//        static void Function(string text)
//        {
//            Console.WriteLine(text);
//        }

//        static Delegate PrintTextAgainAndAgain = new Delegate((string text) => Function(text));



      

//    }
//}
