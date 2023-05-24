//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////IEnumerable
////https://www.youtube.com/watch?v=WWtNNyg2kSw
////
////
////


//namespace ConsoleApp1.CodeWars
//{

//    public class Class2
//    {

//        public static void Main(string[] args)
//        {

//             var numbers=new List<int>() { 1,2,3,4,5,6,7};
//            //var filtered=from i in numbers where i%2==0 select i;
//            var filtered = numbers.Where(x => x % 2 == 0);//.ToList();
//            //var means IEnumerable

//            numbers.Add(10);//this will be shown in the resulted numbers
//                            //because IEnumerable is interface and does not
//            numbers.Add(11);//store values in the memory


//            //convert IEnumerable .ToList and you will see this one 
//            //filtered.Add(12);

//            foreach (int i in filtered)
//            {
//                Console.WriteLine(i);
//            }

//            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");

//            //1 To be able to iterate through object (team) and its objects (players)
//            //you have to implement IEnumerable interface in Team class : IEnumerable<Player>
//            Team team = new Team();

//            foreach(Player player in team)
//            {
//                Console.WriteLine(player.FirstName);
               
//            }
//            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");


//            //2 
//            //you can then filter the Team class and show only specific players using LINQ
//            var filteredTeam=from pl in team where pl.LastName.Contains('1') select pl;
//            //or convert them to a new array using .ToList
//            //var filteredTeam=team.Where(p => p.LastName.Contains('1')).ToList();

//            foreach (Player pl in filteredTeam)
//            {
//                Console.WriteLine(pl.LastName);

//            }

//        }

//    }

//    internal class Player
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }

//        public Player(string firstName, string lastName)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//        }


//    }

//    internal class Team: IEnumerable<Player>
//    {

//        private readonly List<Player> _players = new List<Player>
//        {
//            new Player("Player","11"),
//            new Player("Player","11"),
//            new Player("Player","11"),
//            new Player("Player","11"),
//            new Player("Player","11"),
//            new Player("Player","11"),

//        };

//        public IEnumerator<Player> GetEnumerator()
//        {
//          return _players.GetEnumerator();
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            throw new NotImplementedException();
//        }
//    }




//}

