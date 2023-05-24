//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Runtime.Caching;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns.various
//{
//    // Storing data in an object
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }
//    }

//    public class Programm
//    {

//        public static void Main()
//        {
//            Person person = RetrievePersonFromDatabase();

//            // Store data in cache with a cache key
//            string cacheKey = "personCacheKey";
//            MemoryCache cache = MemoryCache.Default;
//            cache.Add(cacheKey, person, DateTimeOffset.Now.AddMinutes(10));


//            Stopwatch stopwatch = new Stopwatch();

//            stopwatch.Start();
//            // Retrieve data from cache
//            Person cachedPerson = cache.Get(cacheKey) as Person;
//            Console.WriteLine("Name: " + cachedPerson.Name);
//            Console.WriteLine("Age: " + cachedPerson.Age);
//            stopwatch.Stop();
//            Console.WriteLine("Time elapsed for Cache: {0}", stopwatch.Elapsed);

//            stopwatch.Reset();

//            stopwatch.Start();
//            //Use data from the HeapObject
//            Console.WriteLine("Name: " + person.Name);
//            Console.WriteLine("Age: " + person.Age);
//            stopwatch.Stop();
//            Console.WriteLine("Time elapsed for HeapObject: {0}", stopwatch.Elapsed);
//        }




//        public static Person RetrievePersonFromDatabase()
//        {
//            // Simulate data retrieval from database
//            return new Person { Name = "John Smith", Age = 30 };
//        }





//    }

//}
