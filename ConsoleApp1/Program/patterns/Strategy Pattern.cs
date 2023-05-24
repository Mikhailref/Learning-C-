//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{

//    interface IVhichle
//    {
//        void Drive();
//    }
//    class Strategy1 : IVhichle
//    {
//        public void Drive()
//        {
//            Console.WriteLine("Driving a Car");
//        }
//    }

//    class Strategy2 : IVhichle
//    {
//        public void Drive()
//        {
//            Console.WriteLine("Driving a Bus");
//        }
//    }
//    class Garage
//    {
//        private IVhichle _vhicle;

//        public Garage(IVhichle strategy)
//        {
//            _vhicle = strategy;
//        }

//        public void ExecuteStrategy()
//        {
//            _vhicle.Drive();
//        }
//    }

//    public class Programm
//    {
//        static void Main(string[] args)
//        {

//            Garage garage = new Garage(new Strategy1());
//            garage.ExecuteStrategy();

//            garage = new Garage(new Strategy2());
//            garage.ExecuteStrategy();
//        }

//    }



//}
