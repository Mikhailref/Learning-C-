//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

/////////https://habr.com/ru/articles/213809/ REFFERENCE TO THE CODE EXPLANATION

//namespace ConsoleApp1.Program.Methods.various.Delegates
//{

//    class Handler_I
//    {
//        public void Message()
//        {

//            Console.WriteLine("it is 71!");
//        }
//    }

//    class Handler_II
//    {
//        public void Message()
//        {
//            Console.WriteLine("Yes, it is 71!");
//        }
//    }
//    class ClassCounter
//    {

//        public delegate void Method();//DELEGTE

//        public event Method onCount;//EVENT

//        public void Count()
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                if (i == 1)
//                {
//                    if (onCount != null)
//                    {

//                        onCount.Invoke();

//                    }

//                }
//            }
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ClassCounter Counter = new ClassCounter();
//            Handler_I Handler1 = new Handler_I();
//            Handler_II Handler2 = new Handler_II();


//            Counter.onCount += Handler1.Message;
//            Counter.onCount += Handler2.Message;
//            //Counter.onCount -= Handler2.Message;
//            Counter.Count();

//            ////////Counter.onCount is the event
//            ////////Handler1.Message is the eventHandler
//            ////////Counter.Count() is what raises the event
//            ////////when the count reaches 1, 
//            ////////the onCount event is raised\
//            ////////by invoking the delegate that the onCount event is pointing to.
//            ////////
//            ////////In C#, an event is a way for an object to notify other objects 
//            ////////when something interesting happens. Behind the scenes, an event 
//            ////////is implemented using a delegate, which is a type that encapsulates a method.
//            ////////
//            ////////In .NET events, the sender parameter is an object that represents the object
//            ////////that raised the event. When an event is raised, the sender is
//            ////////typically the object that is invoking the event.

//        }
//    }


//    //class Program2
//    //{

//    //    delegate void CountDelegate();

//    //    static CountDelegate onCount;

//    //    static void Main(string[] args)
//    //    {
//    //        onCount = Count;
//    //        Button_Click();
//    //    }

//    //    static void Count()
//    //    {
//    //        Console.WriteLine("Counting...");
//    //    }

//    //    static void Button_Click()
//    //    {
//    //        if (onCount != null)
//    //        {

//    //            onCount.Invoke();
//    //        }
//    //    }
//    //}


//}
