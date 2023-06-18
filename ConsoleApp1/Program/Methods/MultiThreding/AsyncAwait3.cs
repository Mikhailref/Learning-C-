//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.Methods.MultiThreding
//{
//    internal class AsyncAwait3
//    {
//        public static async Task Main()
//        {
//            Stopwatch sw = Stopwatch.StartNew();

//            Task<string> teaTask = PreparingTea();
//            Task<string> showerTask = TakingShower();


//            //Task<string> completedTask = await Task.WhenAny(teaTask, showerTask);
//            //await completedTask;
//            //Console.WriteLine(completedTask.Result);

//            //Task<string> remainingTask = completedTask == teaTask ? showerTask : teaTask;
//            //string remainingResult = await remainingTask;
//            //Console.WriteLine(remainingResult);



//            await Task.WhenAny(teaTask, showerTask);
//            Console.WriteLine("the fastest is finished");

//            await Task.WhenAll(teaTask, showerTask);
//            Console.WriteLine("All tasks are finished");

//            Console.WriteLine(teaTask.Result);
//            Console.WriteLine(showerTask.Result);




//            sw.Stop();
//            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
           

//        }


//        public static async Task<string> PreparingTea()
//        {
//            Console.WriteLine("I am going to prepare the tea");
//            await Task.Delay(3000);
//            return "The tea is ready";
//        }

//        public static async Task<string> TakingShower()
//        {
//            Console.WriteLine("I am going to Take the shower");
//            await Task.Delay(1000);
//            return "I am clean now ";
//        }

//        public static async Task<string> GoingToWork()
//        {
//            Console.WriteLine("I am going to Take the shower");
//            await Task.Delay(1000);
//            return "I am clean now ";
//        }



//    }
//}
