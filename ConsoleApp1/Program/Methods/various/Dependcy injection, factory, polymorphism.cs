//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    internal class Dependcy_injection__factory__polymorphism
//    {
//        public interface IVehicle
//        {
//            void SpeedUp();
//        }

//        public class Car : IVehicle
//        {
//            public void SpeedUp()
//            {
//                Console.WriteLine("Car accelerating...");
//            }
//        }

//        public class Bicycle : IVehicle
//        {
//            public void SpeedUp()
//            {
//                Console.WriteLine("Bicycle moving faster...");
//            }
//        }


//        public class VehicleController
//        {
//            private readonly IVehicle _vehicle;

//            public VehicleController(IVehicle vehicle)
//            {
//                _vehicle = vehicle;
//            }

//            public void Drive()
//            {
                
//                _vehicle.SpeedUp();
//            }
//        }


//        public class Programm
//        {
//            public static void Main()
//            {
//                IVehicle car = new Car();
//                IVehicle bicycle = new Bicycle();
//                VehicleController vehicleController = new VehicleController(bicycle);
//                vehicleController.Drive();

//            }




//        }
//    }
//}
