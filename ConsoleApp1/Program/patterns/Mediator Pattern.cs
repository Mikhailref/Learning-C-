//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{

//    // Mediator interface
//    interface IMediator
//    {
//        void SendGroupMessage(string message, IColleague colleague);
//        void SendSeparateMessage(string message, IColleague sender, IColleague receiver);
//    }

//    // Colleague interface
//    interface IColleague
//    {
//        void ReceiveMessage(string message);
//    }

//    // Concrete mediator class
//    class Mediator : IMediator
//    {
//        private List<IColleague> colleagues = new List<IColleague>();

//        public void AddColleague(IColleague colleague)
//        {
//            colleagues.Add(colleague);
//        }

//        public void SendGroupMessage(string message, IColleague colleague)
//        {
//            foreach (IColleague c in colleagues)
//            {
//                if (c != colleague)
//                {
//                    c.ReceiveMessage(message);
//                }
//            }
//        }

//        public void SendSeparateMessage(string message, IColleague sender, IColleague receiver)
//        {
//            receiver.ReceiveMessage(message + " from " + sender.GetType().Name);
//        }




//    }

//    // Concrete colleague classes
//    class Colleague1 : IColleague
//    {
//        private IMediator mediator;

//        public Colleague1(IMediator mediator)
//        {
//            this.mediator = mediator;
//        }

//        public void SendGroup(string message)
//        {
//            mediator.SendGroupMessage(message, this);
//        }
//        public void SendSeparate(string message, IColleague reciever)
//        {
//            mediator.SendSeparateMessage(message, this, reciever);
//        }

//        public void ReceiveMessage(string message)
//        {
//            Console.WriteLine("Colleague 1 received message: " + message);
//        }
//    }

//    class Colleague2 : IColleague
//    {
//        private IMediator mediator;

//        public Colleague2(IMediator mediator)
//        {
//            this.mediator = mediator;
//        }

//        public void SendGroup(string message)
//        {
//            mediator.SendGroupMessage(message, this);
//        }

//        public void SendSeparate(string message, IColleague reciever)
//        {
//            mediator.SendSeparateMessage(message, this, reciever);
//        }

//        public void ReceiveMessage(string message)
//        {
//            Console.WriteLine("Colleague 2 received message: " + message);
//        }
//    }
//    class Colleague3 : IColleague
//    {
//        private IMediator mediator;

//        public Colleague3(IMediator mediator)
//        {
//            this.mediator = mediator;
//        }

//        public void SendGroup(string message)
//        {
//            mediator.SendGroupMessage(message, this);
//        }

//        public void SendSeparate(string message, IColleague reciever)
//        {
//            mediator.SendSeparateMessage(message, this, reciever);
//        }

//        public void ReceiveMessage(string message)
//        {
//            Console.WriteLine("Colleague 3 received message: " + message);
//        }
//    }

//    // Client code
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Mediator mediator = new Mediator();

//            Colleague1 colleague1 = new Colleague1(mediator);
//            Colleague2 colleague2 = new Colleague2(mediator);
//            Colleague3 colleague3 = new Colleague3(mediator);


//            mediator.AddColleague(colleague1);
//            mediator.AddColleague(colleague2);
//            mediator.AddColleague(colleague3);

//            Console.WriteLine("Group Chat");
//            colleague1.SendGroup("Hello, colleagues!");
//            colleague2.SendGroup("Hello, colleagues!");

//            Console.WriteLine("Private Chat");
//            colleague3.SendSeparate("\"Hello Friend\"", colleague1);
//            colleague1.SendSeparate("\"Hello Bro\"", colleague2);

//        }
//    }

//}
