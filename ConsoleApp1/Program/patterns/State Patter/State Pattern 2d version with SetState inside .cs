//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    interface IPlayerState
//    {
//        string Play(Player player);
//        string Pause(Player player);
//        string Stop(Player player);
//    }

//    class PlayState : IPlayerState
//    {
//        public string Play(Player player)
//        {
//            return "Already playing";
//        }

//        public string Pause(Player player)
//        {
//            player.SetState(new PauseState());
//            return "Paused";
//        }


//        public string Stop(Player player)
//        {
//            player.SetState(new StopState());
//            return "Stopped";
//        }
//    }

//    class PauseState : IPlayerState
//    {
//        public string Play(Player player)
//        {
//            player.SetState(new PlayState());
//            return "Resumed playing";
//        }

//        public string Pause(Player player)
//        {
//            return "Already paused";
//        }

//        public string Stop(Player player)
//        {
//            player.SetState(new StopState());
//            return "Stopped";
//        }
//    }

//    class StopState : IPlayerState
//    {
//        public string Play(Player player)
//        {
//            player.SetState(new PlayState());
//            return "Started playing";
//        }

//        public string Pause(Player player)
//        {
//            return "Cannot pause, player is stopped";
//        }

//        public string Stop(Player player)
//        {
//            return "Already stopped";
//        }
//    }

//    class Player
//    {
//        private IPlayerState state;

//        public Player()
//        {
//            state = new StopState();
//        }

//        public void SetState(IPlayerState state)
//        {
//            this.state = state;
//        }

//        public string Play()
//        {
//            return state.Play(this);
//        }

//        public string Pause()
//        {
//            return state.Pause(this);
//        }

//        public string Stop()
//        {
//            return state.Stop(this);

//        }

//        public class Program
//        {
//            public static void Main()
//            {
//                Player player = new Player();
//                Console.WriteLine(player.Play());
//                //Console.WriteLine(player.Stop());
//                Console.WriteLine(player.Pause());
//                //no need in player.SetState(new PlayState());
//                //it is set inside any IPlayerState

//            }
//        }


//    }
//}
