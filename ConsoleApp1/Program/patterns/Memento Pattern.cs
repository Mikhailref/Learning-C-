////using System;
////using System.Collections.Generic;
////using System.Linq;
////using System.Security.Cryptography.X509Certificates;
////using System.Text;
////using System.Threading.Tasks;

////namespace ConsoleApp1.Program.patterns.various
////{

////    public class Game
////    {
////        private string _progress;

////        public void SaveProgress(string progress)
////        {
////            _progress = progress;
////        }

////        public Memento CreateMemento()
////        {
////            return new Memento(_progress);
////        }

////        public void RestoreMemento(Memento memento)
////        {
////            _progress = memento.GetCurrentProgress();
////        }

////        public string GetProgress()
////        {
////            return _progress;
////        }
////    }

////    public class Memento
////    {
////        public string _progress;

////        public Memento(string progress)
////        {
////            _progress = progress;
////        }

////        public string GetCurrentProgress()
////        {
////            return _progress;
////        }
////    }


////    public class Player
////    {
////        public Memento memento;

////        public void SaveProgress(Game game)
////        {
////            memento = game.CreateMemento();
////        }

////        public void RestoreProgress(Game game)
////        {
////            game.RestoreMemento(memento);
////        }
////    }

////    public class Programm
////    {
////        public static void Main()
////        {

////            Game game = new Game();
////            Player player = new Player();
////            game.SaveProgress("player is at stage 4");
////            player.SaveProgress(game);
////            player.RestoreProgress(game);

////            Console.WriteLine(game.GetProgress());
////            Console.WriteLine(player.memento._progress);
////            Console.WriteLine(player.memento.GetCurrentProgress());

////            game.SaveProgress("player is at stage 5");
////            player.SaveProgress(game);
////            player.RestoreProgress(game);


////            Console.WriteLine(game.GetProgress());
////            Console.WriteLine(player.memento._progress);
////            Console.WriteLine(player.memento._progress);





////        }

////    }


////}
