//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////You are designing a game engine where different types
////of game objects (enemies, obstacles, etc.)
////they need to be created dynamically at runtime. Which design pattern
////would you use to decouple the object creation logic from the game logic
////and allow for easy addition of new object types in the future?

//namespace ConsoleApp1.Program.YouTube
//{
//    internal class Design_Pattern_s_Scenario
//    {
//        public interface IObject
//        {
//            void Create();

//        }

//        public class Enemy : IObject
//        {
//            public void Create()
//            {
//                Console.WriteLine("The enemy has been created");
//            }
//        }
        
//        public class Obstacle : IObject
//        {
//            public void Create()
//            {
//                Console.WriteLine("The obstacle has been created");
//            }
//        }

//        public class Rifle : IObject
//        {
//            public void Create()
//            {
//                Console.WriteLine("The Rifle has been created");
//            }
//        }



//        public class ObjectCreator
//        {
//           public IObject CreateObject(string TypeOfObject)
//            {
//                switch (TypeOfObject)
//                {
//                    case "Enemy":
//                        return new Enemy();
//                    case "Obstacle":
//                        return new Obstacle();
//                    case "Rifle":
//                        return new Rifle();
//                    default:
//                        throw new ArgumentException("no valid");
//                }
//            }

//        }

//        public class Client
//        {
//           public static void Main() 
//            { 

//                ObjectCreator objectCreator = new ObjectCreator();
//                IObject enemy = objectCreator.CreateObject("Enemy");
//                enemy.Create();

//                IObject obstacle = objectCreator.CreateObject("Obstacle");
//                obstacle.Create();

//                IObject rifle = objectCreator.CreateObject("Rifle");
//                rifle.Create();


//            }
        
//        }







//    }
//}
