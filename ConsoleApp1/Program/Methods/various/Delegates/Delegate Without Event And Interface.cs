//using System;
//using System.Diagnostics.Contracts;
//using System.Numerics;
//using System.Runtime.Intrinsics.X86;
//using System.Security.Cryptography.X509Certificates;
//using static ConsoleApp1.Program.Methods.various.Delegates.Program;


/////////https://www.youtube.com/watch?v=uAhVpw8zzm4


//namespace ConsoleApp1.Program.Methods.various.Delegates
//{
//// Interfaces provide a more formal contract between the client code
//// and the strategy implementations, and allow for more flexibility
//// in the implementation details.With interfaces, you can define
//// multiple methods and properties, and enforce that all strategy
//// implementations implement them.Interfaces can also be used to
//// define the dependency injection contracts for the strategy implementations.

////On the other hand, delegates are more lightweight and
////can simplify the implementation of the strategy pattern.
////They allow for more concise and expressive code, and can be
////easily passed as arguments to methods.Delegates are also useful
////when you only need to define a single method in the strategy interface.

////In general, if you need a more complex strategy
////interface with multiple methods and properties,
////or if you want to enforce a strict contract between
////the client code and the strategy implementations,
////you should use interfaces.If you only need to define
////a single method in the strategy interface, and if you
////want to keep your code concise and expressive, you can use delegates.
////It's worth noting that both interfaces and delegates
////can be used together to implement the strategy pattern,
////and you can choose the approach that best suits your needs.



//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            //DELEGATES pass function as a parameter 
//            Calculator calc = new Calculator(Add);
//            int result = calc(3, 4);
//            Console.WriteLine("Result of adding 3 and 4: " + result);
//            calc = Subtract;
//            result = calc(3, 4);
//            Console.WriteLine("Result of subtracting 3 from 4: " + result);



//            //INTERFACES pass class as a parameter 
//            IMethod addMethod = new ADD(2, 3);
//            IMethod subtractMethod= new SUBTRACT(4, 3);
//            Calculator2 Calculator = new Calculator2(addMethod);
//            Calculator.Calculate();
//            Calculator= new Calculator2(subtractMethod);
//            Calculator.Calculate();

//        }

//        //DELEGATES
//        public delegate int Calculator(int x, int y);
//        static int Add(int x, int y)
//        {
//            return x + y;
//        }

//        static int Subtract(int x, int y)
//        {
//            return x - y;
//        }




//        //INTERFACES
//        public class Calculator2
//        {
//            private readonly IMethod _method;

//            public Calculator2(IMethod method)
//            {
//                _method=method;
//            }

//            public void Calculate()
//            {
//                int result = _method.Do(_method.x, _method.y);
//                Console.WriteLine(result);
//            }
//        }

//        public interface IMethod
//        {
//            public int x { get; set; }
//            public int y { get; set; }
//            int Do(int x,int y);
//        }

//        public class ADD : IMethod
//        {
//            public int x { get; set; }
//            public int y { get; set; }
//            public ADD(int x, int y)
//            {
//                this.x = x;
//                this.y = y;
//            }

//            public int Do(int x, int y)
//            {
//                return x + y;
//            }
//        }

//        public class SUBTRACT : IMethod
//        {
//            public int x { get; set; }
//            public int y { get; set; }

//            public SUBTRACT(int x, int y)
//            {
//                this.x = x;
//                this.y = y;
//            }

//            public int Do(int x, int y)
//            {
//                return x - y;
//            }
//        }





//    }
//}


