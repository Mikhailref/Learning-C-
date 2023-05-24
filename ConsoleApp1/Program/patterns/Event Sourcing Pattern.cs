//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    public class Order
//    {
//        public int OrderId { get; set; }
//        public string CustomerName { get; set; }
//        public DateTime OrderDate { get; set; }
//    }

//    public class EventCollection
//    {
//        private readonly List<object> _events = new List<object>();

//        public void SaveEvent(object @event)
//        {
//            //add the object to the list
//            _events.Add(@event);
//        }

//        public IEnumerable<object> GetAllEvents()
//        {
//            //return the list of the objects
//            return _events.AsReadOnly();
//        }
//    }

//    public class OrderCreator
//    {
//        private readonly EventCollection _eventCollection;

//        public OrderCreator(EventCollection eventCollection)
//        {
//            _eventCollection = eventCollection;
//        }

//        public int CreateOrder(string customerName)
//        {
//            int orderId = GenerateOrderId();

//            // Create an event representing the order creation
//            Order order = new Order
//            {
//                OrderId = orderId,
//                CustomerName = customerName,
//                OrderDate = DateTime.UtcNow
//            };

//            // Save the event as an object to the event collection
//            _eventCollection.SaveEvent(order);

//            // Return the generated order ID
//            return orderId;
//        }

//        private int GenerateOrderId()
//        {
//            // This is a dummy implementation, replace with your own logic
//            return new Random().Next(1000);
//        }
//    }

//    public class Client
//    {
//        public static void Main(string[] args)
//        {
//            EventCollection eventCollection = new EventCollection();

//            OrderCreator orderCreator = new OrderCreator(eventCollection);

//            // Create a new order as an object and save it in Event Collection
//            orderCreator.CreateOrder("by a customer Alice");
//            orderCreator.CreateOrder("by a customer Mark");
//            orderCreator.CreateOrder("by a customer Fody");

//            // Get all the events as Objects from the Event Collection
//            IEnumerable<object> events = eventCollection.GetAllEvents();

//            // Reconstruct the state of the system by replaying the events
//            foreach (object @event in events)
//            {
//                if (@event is Order order)
//                {
//                    Console.WriteLine($"Order {order.OrderId} created on {order.OrderDate} by {order.CustomerName}");
//                }
//            }
//        }
//    }


   



//}
