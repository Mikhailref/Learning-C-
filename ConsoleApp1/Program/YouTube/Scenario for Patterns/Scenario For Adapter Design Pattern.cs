//using ConsoleApp1.Program.YouTube;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Cache;
//using System.Text;
//using System.Threading.Tasks;



////You are designing a payment gateway integration
////for your e-commerce platform. Which design pattern
////would you use to encapsulate the payment processing
////logic and provide a uniform interface for clients to
////initiate and track payments ?

//namespace ConsoleApp1.Program.YouTube
//{

//    // Adaptee interface that defines the payment processing logic for a specific payment provider
//    public interface IPaymentProvider
//    {
//        void SubmitPayment(decimal amount);
//        string GetPaymentDetails(int paymentId);
//    }



//    // Concrete implementation of the IPaymentProvider interface for PayPal payments
//    public class PayPalPaymentProvider : IPaymentProvider
//    {
//        public void SubmitPayment(decimal amount)
//        {
//            // PayPal payment processing logic
//        }

//        public string GetPaymentDetails(int paymentId)
//        {
//            // PayPal payment status retrieval logic
//            return "Payment through PayPal was successful";
//        }
//    }

//    // Concrete implementation of the IPaymentProvider interface for Stripe payments
//    public class StripePaymentProvider : IPaymentProvider
//    {
//        public void SubmitPayment(decimal amount)
//        {
//            // Stripe payment processing logic
//        }

//        public string GetPaymentDetails(int paymentId)
//        {
//            // Stripe payment status retrieval logic
//            return "Payment through Stripe was successful";
//        }
//    }



//    // Target interface that defines the uniform interface for clients to initiate and track payments
//    public interface IPaymentGateway
//    {
//        void ProcessPayment(decimal amount);
//        string GetPaymentStatus(int paymentId);
//    }


//    // Adapter class that wraps the payment processing logic of a specific payment provider with the IPaymentGateway interface
//    public class PaymentProviderAdapter : IPaymentGateway
//    {
//        private readonly IPaymentProvider _paymentProvider;

//        public PaymentProviderAdapter(IPaymentProvider paymentProvider)
//        {
//            _paymentProvider = paymentProvider;
//        }

//        public void ProcessPayment(decimal amount)
//        {
//            _paymentProvider.SubmitPayment(amount);
//        }

//        public string GetPaymentStatus(int paymentId)
//        {
//            return _paymentProvider.GetPaymentDetails(paymentId);
//        }
//    }

//    // Client code that uses the IPaymentGateway interface to initiate and track payments with different payment providers
//    public class Client
//    {
//        private readonly IPaymentGateway _paymentGateway;

//        public Client(IPaymentGateway paymentGateway)
//        {
//            _paymentGateway = paymentGateway;
//        }

//        public void MakePayment(decimal amount)
//        {
//            _paymentGateway.ProcessPayment(amount);
//        }

//        public string GetPaymentStatus(int paymentId)
//        {
//            return _paymentGateway.GetPaymentStatus(paymentId);
//        }
//    }




//    public class Programm
//    {
//        public static void Main()
//        {
//            IPaymentProvider paypal = new PayPalPaymentProvider();
//            IPaymentProvider stripe = new StripePaymentProvider();


//            IPaymentGateway adapter = new PaymentProviderAdapter(paypal);
//            Client client = new Client(adapter);
//            client.MakePayment(1000);
//            string Result = client.GetPaymentStatus(1);
//            Console.WriteLine(Result);
//        }

//    }

//}


