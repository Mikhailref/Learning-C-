using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ConsoleApp1.Program
//{

//    public interface IWatchMode
//    {
//        void Click();

//    }

//    class RunMode : IWatchMode
//    {
//        private Watch _watch;

//        public RunMode(Watch watch)
//        {
//            _watch = watch;
//        }
//        public void Click()
//        {
//            _watch.SetState(new StopMode(_watch));
//            Console.WriteLine("Stoped");
//        }
//    }

//    class StopMode : IWatchMode
//    {
//        private Watch _watch;

//        public StopMode(Watch watch)
//        {
//            _watch = watch;
//        }
//        public void Click()
//        {
//            _watch.SetState(new RunMode(_watch));
//            Console.WriteLine("Running");
//        }

//    }

//    public class Watch
//    {
//        private IWatchMode _mode;
//        public Watch()
//        {
//            _mode = new StopMode(this);
//        }

//        public void SetState(IWatchMode mode)
//        {
//            _mode = mode;
//        }

//        public void Click()
//        {
//            _mode.Click();
//        }

//    }

//    public class Practice
//    {
//        public static void Main()
//        {
//            Watch watch = new Watch();
//            watch.Click();
//            watch.Click();
//            watch.Click();
//        }
//    }
//}

    //////////////OR WE CAN DO IT LIKE THAT/////////////////


////    public interface IWatchMode
////    {
////        void Click(Watch watch);

////    }

////    class RunMode : IWatchMode
////    {
////        public void Click(Watch watch)
////        {
////            watch.SetState(new StopMode());
////            Console.WriteLine("Stoped");
////        }
////    }

////    class StopMode : IWatchMode
////    {
////        public void Click(Watch watch)
////        {
////            watch.SetState(new RunMode());
////            Console.WriteLine("Running");
////        }

////    }

////    public class Watch
////    {
////        private IWatchMode _mode;
////        public Watch()
////        {
////            _mode = new StopMode();
////        }

////        public void SetState(IWatchMode mode)
////        {
////            _mode = mode;
////        }

////        public void Click()
////        {
////            _mode.Click(this);
////        }

////    }

////    public class Practice
////    {
////        public static void Main()
////        {
////            Watch watch = new Watch();
////            watch.Click();
////            watch.Click();
////            watch.Click();
////        }


////    }

////}
