//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    // Define the complex subsystem
//    class GrindBeens
//    {
//        public void Operation()
//        {
//            Console.WriteLine("BeensGrinding");
//        }
//    }

//    class BoilWater
//    {
//        public void Operation()
//        {
//            Console.WriteLine("WaterBoiling");
//        }
//    }



//    // Define the facade
//    class CoffeeMachine
//    {
//        private GrindBeens Grinder;
//        private BoilWater Boiler;

//        public CoffeeMachine()
//        {
//            Grinder = new GrindBeens();
//            Boiler = new BoilWater();

//        }

//        // Provide a simplified interface to the subsystem
//        public void Operation()
//        {
//            Grinder.Operation();
//            Boiler.Operation();
//            Console.WriteLine("Your Coffee is ready");
//        }
//    }

//    // Client code
//    class Client
//    {
//        static void Main(string[] args)
//        {
//            CoffeeMachine facade = new CoffeeMachine();
//            facade.Operation();
//        }
//    }

//}
