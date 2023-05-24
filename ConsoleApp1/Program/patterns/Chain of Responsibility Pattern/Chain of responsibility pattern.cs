//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    public abstract class Handler
//    {
//        protected Handler successor;

//        public void SetSuccessor(Handler successor)
//        {
//            this.successor = successor;
//        }

//        public abstract void HandleRequest(int request);
//    }

//    public class ConcreteHandler1 : Handler
//    {
//        public override void HandleRequest(int request)
//        {
//            if (request >= 0 && request < 10)
//            {
//                Console.WriteLine($"{this.GetType().Name} handled the request {request}");
//            }
//            else if (successor != null)
//            {
//                successor.HandleRequest(request);
//            }
//        }
//    }

//    public class ConcreteHandler2 : Handler
//    {
//        public override void HandleRequest(int request)
//        {
//            if (request >= 10 && request < 20)
//            {
//                Console.WriteLine($"{this.GetType().Name} handled the request {request}");
//            }
//            else if (successor != null)
//            {
//                successor.HandleRequest(request);
//            }
//        }
//    }

//    public class ConcreteHandler3 : Handler
//    {
//        public override void HandleRequest(int request)
//        {
//            if (request >= 20 && request < 30)
//            {
//                Console.WriteLine($"{this.GetType().Name} handled the request {request}");
//            }
//            else if (successor != null)
//            {
//                successor.HandleRequest(request);
//            }
//        }
//    }

//    public class Program
//    { 
//        public static void Main()
//        {
//            Handler h1 = new ConcreteHandler1();
//            Handler h2 = new ConcreteHandler2();
//            Handler h3 = new ConcreteHandler3();

//            h1.SetSuccessor(h2);
//            h2.SetSuccessor(h3);

//            // Process requests
//            h1.HandleRequest(5);
//            h1.HandleRequest(15);
//            h1.HandleRequest(25);

//        }

//    }



//}
