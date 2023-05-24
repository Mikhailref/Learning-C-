//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    using System;

//    public abstract class AlgorithmTemplate
//    {
//        public void Execute()
//        {
//            Step1();
//            Step2();
//            Step3();
//            Step4();
//        }

//        protected virtual void Step1()
//        {
//            Console.WriteLine("Default implementation of Step 1");
//        }

//        protected virtual void Step2()
//        {
//            Console.WriteLine("Default implementation of Step 2");
//        }

//        protected virtual void Step3()
//        {
//            Console.WriteLine("Default implementation of Step 3");
//        }

//        protected virtual void Step4()
//        {
//            Console.WriteLine("Default implementation of Step 4");
//        }
//    }

//    public class AlgorithmA : AlgorithmTemplate
//    {
//        protected override void Step1()
//        {
//            Console.WriteLine("Custom implementation of Step 1 for Algorithm A");
//        }

//        protected override void Step3()
//        {
//            Console.WriteLine("Custom implementation of Step 3 for Algorithm A");
//        }
//    }

//    public class AlgorithmB : AlgorithmTemplate
//    {
//        protected override void Step2()
//        {
//            Console.WriteLine("Custom implementation of Step 2 for Algorithm B");
//        }

//        protected override void Step4()
//        {
//            Console.WriteLine("Custom implementation of Step 4 for Algorithm B");
//        }
//    }

//    public class Program
//    {
//        public static void Main()
//        {
//            AlgorithmTemplate algorithmA = new AlgorithmA();
//            algorithmA.Execute();

//            Console.WriteLine("---------------------------------------");

//            AlgorithmTemplate algorithmB = new AlgorithmB();
//            algorithmB.Execute();

//            Console.ReadLine();
//        }
//    }

//}
