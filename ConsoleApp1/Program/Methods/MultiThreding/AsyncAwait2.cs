//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Diagnostics.Metrics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.Methods.NewFolder
//{
//    /// <summary>
//    /// https://www.youtube.com/watch?v=5a6WCBftjvw
//    /// </summary>
//    internal class Async_Await
//    {
//        public static async Task Main()
//        {
//            Stopwatch sw = new Stopwatch();
//            sw.Start();

//            Task task = PrepareTeaAsync();
//            ////the execution of COUNTER is not blocked if the FIRST is not finished
//            ////and the code is running on different threads even if the FIRST is not finished

//            ////await task;
//            ////wills start the counter only after the task is finished
            
//            Counter();

            


//            sw.Stop();
//            Console.WriteLine(sw.Elapsed.TotalSeconds);

//        }

//        public static async Task PrepareTeaAsync()
//        {
//            Console.WriteLine("Preparing Tea");
//            await Task.Delay(3000);
//            Console.WriteLine("Tea is ready");
//        }

//        public static void Counter()
//        {
//            Console.WriteLine("Timer is set off");
//            int num = 0;
//            while (num++ < 10)
//            {
//                Thread.Sleep(500);
//                Console.WriteLine(num);
//            }
//        }
//    }
//}
