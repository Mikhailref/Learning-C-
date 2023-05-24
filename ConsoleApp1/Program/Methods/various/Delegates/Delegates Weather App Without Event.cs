//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.Methods.various.Delegates
//{
//    public delegate string WeatherDelegate();

//    public class WeatherApp
//    {
//        private WeatherDelegate getWeatherDelegate;

//        public WeatherApp(WeatherDelegate getWeatherDelegate)
//        {
//            this.getWeatherDelegate = getWeatherDelegate;
//        }

//        public string GetWeather()
//        {
//            return getWeatherDelegate();
//        }
//    }

//    public class WeatherSource1
//    {
//        public string GetWeatherData()
//        {
//            // Code to retrieve weather data from source 1
//            return "Weather data from source 1";
//        }
//    }

//    public class WeatherSource2
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

//            // Create an instance of the WeatherApp and pass in the delegate for the preferred weather source
//            WeatherApp app = new WeatherApp(delegate { return source2.GetWeatherData(); });

//            // Get the weather data using the preferred weather source
//            string weatherData = app.GetWeather();

//            Console.WriteLine(weatherData);
//        }
//    }

//}
