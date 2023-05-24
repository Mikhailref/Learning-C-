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

//        // Declare the event
//        public event EventHandler WeatherRetrieved;

//        public WeatherApp(WeatherDelegate getWeatherDelegate)
//        {
//            this.getWeatherDelegate = getWeatherDelegate;
//        }

//        public void GetWeather()
//        {
//            string weatherData = getWeatherDelegate();

//            // Raise the event
//            OnWeatherRetrieved(EventArgs.Empty);

//            Console.WriteLine(weatherData);


//        }

//        protected virtual void OnWeatherRetrieved(EventArgs e)
//        {
//            // Raise the event
//            WeatherRetrieved?.Invoke(this, e);
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

//            // Attach an event handler to the WeatherRetrieved event
//            app.WeatherRetrieved += WeatherRetrievedHandler;

//            // Get the weather data using the preferred weather source
//            app.GetWeather();

            
//        }

//        static void WeatherRetrievedHandler(object sender, EventArgs e)
//        {
//            Console.WriteLine("Weather data retrieved!");
//        }
//    }

//}
