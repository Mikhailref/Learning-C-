//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    // Define the state interface
//    public interface PlayerState
//    {
//        void Play();
//        void Pause();
//        void Stop();
//    }

//    // Define the concrete states
//    public class PlayMode : PlayerState
//    {
//        public void Play()
//        {
//            Console.WriteLine("Already playing.");
//        }

//        public void Pause()
//        {
//            Console.WriteLine("Paused the playback.");
//        }

//        public void Stop()
//        {
//            Console.WriteLine("Stopped the playback.");
//        }
//    }

//    public class PauseMode : PlayerState
//    {
//        public void Play()
//        {
//            Console.WriteLine("Resumed the playback.");
//        }

//        public void Pause()
//        {
//            Console.WriteLine("Already paused.");
//        }

//        public void Stop()
//        {
//            Console.WriteLine("Stopped the playback.");
//        }
//    }

//    public class StopMode : PlayerState
//    {
//        public void Play()
//        {
//            Console.WriteLine("Started playing.");
//        }

//        public void Pause()
//        {
//            Console.WriteLine("Can't pause, playback is stopped.");
//        }

//        public void Stop()
//        {
//            Console.WriteLine("Already stopped.");
//        }
//    }

//    // Define the context
//    public class Player
//    {
//        private PlayerState _state;

//        public Player(PlayerState state)
//        {
//            _state = state;
//        }

//        public void SetState(PlayerState state)
//        {
//            _state = state;
//        }

//        public void Play()
//        {
//            _state.Play();
//        }

//        public void Pause()
//        {
//            _state.Pause();
//        }

//        public void Stop()
//        {
//            _state.Stop();
//        }


//    }

//    public class Programm
//    {
//        public static void Main()
//        {
//            // Usage example
//            var player = new Player(new StopMode());
//            player.Stop(); // Output: Already stopped.
//            player.Play(); // Output: Started playing.
//            player.Pause(); // Output: Can't pause, playback is stopped.


//            player.SetState(new PlayMode());
//            player.Play(); // Output: Already playing.
//            player.Pause(); // Output: Paused the playback.
//            player.Stop();

//            player.SetState(new PauseMode());
//            player.Pause(); // Output: Can't pause, playback is stopped.

//        }

//    }

//}
