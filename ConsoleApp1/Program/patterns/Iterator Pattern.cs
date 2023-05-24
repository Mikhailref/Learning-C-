//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{
//    using System;
//    using System.Collections;
//    using static ConsoleApp1.Program.patterns.Aggregate;

//    // The Aggregate class represents a collection of items.
//    class Aggregate
//    {
//        private ArrayList items = new ArrayList();

//        public void AddItem(object item)
//        {
//            items.Add(item);
//        }

//        public Iterator CreateIterator()
//        {
//            return new Iterator(this);
//        }

//        public int Count
//        {
//            get { return items.Count; }
//        }

//        // The Iterator class provides a way to iterate over the collection's items.
//        public class Iterator
//        {
//            private Aggregate aggregate;
//            private int index;

//            public Iterator(Aggregate aggregate)
//            {
//                this.aggregate = aggregate;
//                index = 0;
//            }

//            public bool HasNext()
//            {
//                return (index < aggregate.Count);
//            }

//            public object Next()
//            {
//                if (HasNext())
//                {
//                    return aggregate.items[index++];
//                }
//                else
//                {
//                    return null;
//                }
//            }
//        }
//    }

//    // The client code creates an instance of the Aggregate class and uses its Iterator to traverse the collection.
//    class Client
//    {
//        static void Main(string[] args)
//        {
//            Aggregate aggregate = new Aggregate();
//            aggregate.AddItem("Item 1");
//            aggregate.AddItem("Item 2");
//            aggregate.AddItem("Item 3");

//            Iterator iterator = aggregate.CreateIterator();

//            while (iterator.HasNext())
//            {
//                Console.WriteLine(iterator.Next());
//            }
//        }
//    }

//}
