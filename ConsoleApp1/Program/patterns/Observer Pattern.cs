//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{

//    interface IObserver
//    {
//        void Update(string command);
//        void FollowCommand();
//    }

//    interface ISubject
//    {
//        void Attach(IObserver observer);
//        void Detach(IObserver observer);

//        public void SetCommand(string command);

//        public void Notify();
//    }

//    class YouTubeChannel : ISubject
//    {
//        private List<IObserver> observers = new List<IObserver>();
//        private string _command;

//        public void Attach(IObserver observer)
//        {
//            observers.Add(observer);
//        }

//        public void Detach(IObserver observer)
//        {
//            observers.Remove(observer);
//        }

//        public void SetCommand(string command)
//        {
//            _command = command;
//            Notify();
//        }

//        public void Notify()
//        {
//            foreach (var observer in observers)
//            {
//                observer.Update(_command);
//            }
//        }


//    }

//    class Subscriber : IObserver
//    {
//        private string _command;

//        public void Update(string command)
//        {
//            _command = command;
//            Console.WriteLine($"Subscriber: command is now set to {_command}");

//        }

//        public void FollowCommand()
//        {
//            Console.WriteLine($"Subscriber: I am  {_command}ing");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            ISubject subject = new YouTubeChannel();
//            IObserver observer1 = new Subscriber();


//            subject.Attach(observer1);

//            subject.SetCommand("watch");

//            observer1.FollowCommand();

//        }
//    }

//    //changes

//}
