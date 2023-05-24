//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Cache;
//using System.Text;
//using System.Threading.Tasks;

////You are building a web application where
////you need to fetch data from multiple APIs
////and aggregate them into a single response.
////Which design pattern would you use to
////encapsulate the API calls and provide
////a uniform interface for clients to access
////the aggregated data?

//namespace ConsoleApp1.Program.YouTube
//{
//    class First
//    {
//      public void FetchData()
//        {

//        }
//    }

//    class Second
//    {
//        public void FetchData()
//        {

//        }
//    }

//    class Aggregator
//    {
//        private First first;
//        private Second second;

//        public Aggregator()
//        {
//            first = new First();
//            second = new Second();
//        }

//        public void Method()
//        {
//            first.FetchData();
//            second.FetchData();
//        }
//    }

//    public class Client
//    { 
//      public static void Main() 
//        {
//          Aggregator aggregator = new Aggregator();
//            aggregator.Method();
//        }
    
//    }

//}
