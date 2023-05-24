//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace ConsoleApp1.CodeWars
//{
//    public class Player
//    {
//        public string Name { get; set; }
//        public int Wins { get; set; }
//        public int[] Cards { get; set; }

//        public Player(string name, int wins, int[] cards)
//        {
//            Name = name;
//            Wins = wins;
//            Cards = cards;
//        }
//    }

   
//    internal class Class5
//    {      
//      static void Main()
//        {
//            Player player1 = new Player("Frank", 0, new int[] { 0, 1, 2, 3 });
//            Player player2 = new Player("Sam", 0, new int[] { 4, 5, 6, 7 });
//            Player player3= new Player("Tom", 0, new int[] { 8, 9, 10, 11 });

//            Method(player1, player1, player1);
//        }
//        static bool Method(Player player1, Player player2, Player player3)
//        {
//            Player [] players=new Player[3];
//            players[0]=player1;
//            players[1]=player2;
//            players[2]=player3;

//            List<string> Turn=new List <string> { "Frank", "Sam", "Tom" };

//            int Index;
//            string NameOfPlayer="unknown";
            


//            foreach (Player player in players)
//            {
//                foreach (int card in player.Cards)
//                {
//                    if (card == 0)
//                    {
//                      Index= Array.IndexOf(player.Cards, card);
//                      player.Cards[Index]=00;
//                      NameOfPlayer = Name(player);
//                    }
//                }

//                if (NameOfPlayer == "Frank")
//                {
//                    Step(player, NameOfPlayer);
//                    NameOfPlayer = Name(player);

//                }

//                else if (NameOfPlayer == "Sam")
//                {

//                    NameOfPlayer = Name(player);

//                }

//                else if (NameOfPlayer == "Tom")
//                {

//                    NameOfPlayer = Name(player);

//                }
                
                



//            }
//        }
//        static void Step(Player player, string NameOfPlayer)
//        {
//            for(int i =0; i < player.Cards.Length ;i++)
//            {
//                if (player.Cards[i] != 00)
//                {
//                    player.Cards[i] = 00;
                    
//                }
                    


//            }

//        }
//        static string Name(Player player)
//        {
//            switch (player.Name)
//            {
//                case "Frank":
//                    return "Sam";
//                    break;

//                case "Sam":
//                    return "Tom";
//                    break;

//                case "Tom":
//                    return "Frank";
//                    break;
//            }

//            return null;
//        }

       


//    }
//}




////if (Array.Exists(Frank, numbers => numbers.Equals(num==0)))
////{
////   foreach (int number in Frank)
////    {
////        if (number==num)
////        {
////            Frank=Frank.Except(new int[] {num}).ToArray();
////        }
////    }
////}



////if (Array.Exists(Sam, numbers => numbers.Equals(num)))
////{

////}


////if (Array.Exists(Sam, numbers => numbers.CompareTo(0) == 0))
////{
////    Console.WriteLine("true");
////}

////if (Array.Exists(Sam, numbers => numbers.)
////{
////    Console.WriteLine("true");
////}

////return false;




////        }
////    }
////}
