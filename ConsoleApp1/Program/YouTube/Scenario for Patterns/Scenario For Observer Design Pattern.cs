//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////You are building a chat application 
////where you need to implement a notification 
////system to alert users of new messages.
////Which design pattern would you use to 
////decouple the notification logic from the 
////chat logic and provide a flexible mechanism 
////for adding new notification channels in the future?

//namespace ConsoleApp1.Program.YouTube
//{
//    interface IUser
//    {
//        void Update(string notification);
//        void Follow();

//    }

//    interface IChannel
//    {
//        void Attach(IUser user);
//        void Detach(IUser user);

//        public void SetNotification(string notification);

//        public void Notify();

//    }

//    class YouTubeChannel : IChannel
//    {
//        private List<IUser> users;
//        private string _command;

//        public YouTubeChannel()
//        {
//            users = new List<IUser>();
//        }
//        public void Attach(IUser user)
//        {
//            users.Add(user);
//        }

//        public void Detach(IUser user)
//        {
//            users.Remove(user);
//        }

//        public void SetNotification(string command)
//        {
//            _command = command;
//            Notify();
//        }

//        public void Notify()
//        {
//            foreach (var user in users)
//            {
//                user.Update(_command);
//            }
//        }
//    }

//    public class User : IUser
//    {
//        private string _command;
//        public void Update(string command)
//        {
//            _command = command;
//        }

//        public void Follow()
//        {
//            Console.WriteLine($"I am following {_command} command ");
//        }

//    }


//    class Client
//    {
//        public static void Main()
//        {
//            IUser user = new User();
//            IChannel channel=new YouTubeChannel();  
//            channel.Attach(user);
//            channel.SetNotification("watch a new video");
//            user.Follow();
//        }
//    }


//}

