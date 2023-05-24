//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Runtime.Caching;
//using System.Timers;

//namespace ConsoleApp1.Program.patterns
//{
//    //Caching pattern: This pattern stores frequently
//    //accessed data in memory, allowing you to retrieve
//    //it quickly without needing to access the original
//    //data source. It's like a restaurant that keeps popular
//    //dishes pre-made and ready to serve, so they can be
//    //served quickly when ordered.

//    class MyDataClient
//    {
//        private ObjectCache _cache;
//        private string _cacheKey;

//        public MyDataClient()
//        {
//            // Initialize _cache object with a name
//            _cache = MemoryCache.Default;

//            // Define _cacheKey
//            _cacheKey = "myData";
//        }

//        public List<string> GetData()
//        {
//            // Try to get the value from cache
//            List<string> cachedData = _cache.Get(_cacheKey) as List<string>;

//            // If the value is not in cache, load it and add it to the cache
//            if (cachedData == null)
//            {
//                Console.WriteLine("Cache is missing");

//                // Load the data (in this example, just a list of strings)
//                List<string> data = LoadData();

//                // Add the data to the cache with an expiration time of 10 seconds
//                CacheItemPolicy policy = new CacheItemPolicy
//                {
//                    AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(10)
//                };
//                _cache.Add(_cacheKey, data, policy);

//                // Use the data
//                cachedData = _cache.Get(_cacheKey) as List<string>;
//            }
//            else
//            {
//                Console.WriteLine("Cache is present");
//            }

//            // Return the data
//            return cachedData;
//        }

//        private List<string> LoadData()
//        {
//            // Here you could load the data from a database, a file, a web service, etc.
//            // For simplicity, we will just return a hard-coded list of strings.
//            return new List<string> { "Apple", "Banana", "Orange" };
//        }

//    }


//    class Client
//    {
//        static void Main(string[] args)
//        {
//            //just learning how to cache data
//            CacheItemPolicy policy = new CacheItemPolicy
//            {
//                AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(6)
//            };

//            List<string> list = new List<string> { "hello", "world" };
//            MemoryCache.Default.Add("NewData", list, policy);

//            System.Timers.Timer timer = new System.Timers.Timer(2000);
//            timer.Elapsed += OnTimedEvent;
//            timer.AutoReset = true;
//            timer.Enabled = true;

//            static void OnTimedEvent(object source, ElapsedEventArgs e)
//            {
//                List<string> Mydata = MemoryCache.Default.Get("NewData") as List<string>;

//                Console.WriteLine("Data:");
//                foreach (string item in Mydata)
//                {
//                    Console.WriteLine(item);
//                }
//            }

//            Console.ReadLine();

//            ////below is the code related to the CLASS MYDATACLIENT above

//            //MyDataClient myDataClient = new MyDataClient();

//            //while (true)
//            //{
//            //    Console.WriteLine("Press enter to get data from cache");
//            //    Console.ReadLine();

//            //    List<string> data = myDataClient.GetData();

//            //    Console.WriteLine("Data:");
//            //    foreach (string item in data)
//            //    {
//            //        Console.WriteLine(item);
//            //    }
//            //}


//        }
//    }


//}
