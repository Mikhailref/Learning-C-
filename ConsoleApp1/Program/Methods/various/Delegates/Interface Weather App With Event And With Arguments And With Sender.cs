//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.Methods.various.Delegates
//{

//    //REMEMBER EVENT-ARGUMENT-METHODS

//    //REMEMBER THERE IS ALWAYS A DELEGATE WITH AN EVENT 
//    //EVEN IF THE EVENT IS NOT DEFINED EXPLICITLY
//    //DELEGATE CAN BE USED WITHOUT EVENTS

//    //REMEMBER DELEGATES ARE CLASSES TO PASS METHODS WITH THE SAME SIGNATURE
//    //public delegate int Calculator(int x, int y);
//    // static int Add(int x, int y)
//    //{
//    //    return x + y;
//    //}
//    //Calculator calc = new Calculator(Add);
//    //int result = calc(3, 4);

//    //USE DELEGATE(DELEGATE AS A CLASS) OR INTERFACES

//    public class WeatherEventArgs : EventArgs
//    {
//        public string WeatherData { get; set; }
//    }

//    public interface IWeatherSource
//    {
//        string GetWeatherData();
//    }

//    public class WeatherApp
//    {
//        private IWeatherSource weatherSource;

//        // Declare the event with arguments
//        public event EventHandler<WeatherEventArgs> WeatherRetrieved;

//        public WeatherApp(IWeatherSource weatherSource)
//        {
//            this.weatherSource = weatherSource;
//        }

//        public void GetWeather()
//        {
//            string weatherData = weatherSource.GetWeatherData();

//            WeatherEventArgs args = new WeatherEventArgs();

//            //Here we set the arguments
//            args.WeatherData = weatherData;

//            // Raise the event
//            OnWeatherRetrieved(args);

//        }

//        protected virtual void OnWeatherRetrieved(WeatherEventArgs args)
//        {
//            // Raise the event
//            WeatherRetrieved?.Invoke(this, args);
//        }
//    }



//    public class WeatherSource1 : IWeatherSource
//    {
//        public string GetWeatherData()
//        {
//            // Code to retrieve weather data from source 1
//            return "Weather data from source 1";
//        }
//    }

//    public class WeatherSource2 : IWeatherSource
//    {
//        public string GetWeatherData()
//        {
//            // Code to retrieve weather data from source 2
//            return "Weather data from source 2";
//        }
//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            // Create instances of the weather sources
//            WeatherSource1 source1 = new WeatherSource1();
//            WeatherSource2 source2 = new WeatherSource2();

//            // Create an instance of the WeatherApp and pass in the preferred weather source
//            WeatherApp app = new WeatherApp(source2);

//            // Attach an event handler to the WeatherRetrieved event
//            app.WeatherRetrieved += WeatherRetrievedHandler;
//            app.WeatherRetrieved += AnotherWeatherRetrievedHandler;

//            //I have an event with arguments, and  I pass the arguments to a method
//            //I associate the method with the event by using +=
//            //so when I raise the event, the method associated with that event
//            //will be invoked with the arguments



//            app.GetWeather();

//        }

//        static void WeatherRetrievedHandler(object sender, WeatherEventArgs args)
//        {
//            Console.WriteLine("Weather data retrieved!" + args.WeatherData);
//            Console.WriteLine(sender);//sender is the class WeaterApp

//        }

//        static void AnotherWeatherRetrievedHandler(object sender, WeatherEventArgs args)
//        {
//            Console.WriteLine("Another weather data retrieved! " + args.WeatherData);
//            Console.WriteLine(sender);//sender is the class WeaterApp
//        }

//    }

//}
