//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Mail;
//using System.Text;
//using System.Threading.Tasks;

////
////
////
////
////


//namespace ConsoleApp1.CodeWars
//{

//    class Clients
//    {
//        public string address { get; set; }
//        public bool booly { get; set; }

//    }

//    class Programm1
//    {
//        public static Clients client1 = new Clients();

//        public static Clients Validation()
//        {

//            client1.address = "reforma@gmail.com";

//            var Email = new MailAddress(client1.address);
//            //if the email is verified then the var Email
//            //can be created with the exact adress
//            //so you can compare it later and return whatever needed

//            if (Email.Address == client1.address)
//            {
//                client1.booly = true;
//                return client1;
//            }

//            else
//                client1.booly = false;
//            return client1;
//        }
//    }

//        class Programm2
//        {
//            public static Clients client1a = new Clients();
//            public static void Main(string[] args)
//            {
//                client1a = Programm1.Validation();

//                Console.WriteLine(client1a.address);
//                Console.WriteLine(client1a.booly);

//            }
//        }

    
//}

