//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//////https://www.youtube.com/watch?v=bsVOPFO3co8

//namespace ConsoleApp1.Program.Methods.various.Delegates
//{
//    class Button
//    {
//        // Define the delegate for the Clicked event
//        // You can use it without (object sender, EventArgs e)

//        //public delegate void ClickedEventHandler();

//        // if so remove (object sender, EventArgs e) throught the CODE
//        // or use it with sender and aruments

//        public delegate void ClickedEventHandler(object sender, EventArgs e);

//        // Define the Clicked event

//        public event ClickedEventHandler Clicked;


//        //OR
//        //use the.NET EventHandler Without Defining the delegate
//        //it requires sender and arguments by default
//        //public event EventHandler Clicked;

//        //REMEMBER THERE IS ALWAYS A DELEGATE(object sender, EventArgs e) ASSOCIATED WITH THE EVENT
//        //EVEN IF IT IS NOT DEFINED EXPLICITLY

//        // Raise the Clicked event
//        protected void OnClicked()
//        {
//            Clicked?.Invoke(this, EventArgs.Empty);

//        }

//        //Handle the button click
//        public void Click()
//        {
//            OnClicked();
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Button myButton = new Button();
//            myButton.Clicked += MyButtonClickedMethod;

//            //Click the button
//            myButton.Click();

//        }

//        static void MyButtonClickedMethod(object sender, EventArgs e)
//        {
//            Console.WriteLine("Button clicked!");
//        }
//    }

//}
