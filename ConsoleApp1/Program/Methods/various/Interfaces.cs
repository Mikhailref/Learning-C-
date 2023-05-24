//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.CodeWars.patterns
//{
//    interface IEmployee
//    {
//        string Name { get; set; }

//        int Counter { get;}
//    }

//    public class Employee : IEmployee
//    {
//        public static int numberOfEmployees;

//        private string _name;
//        public string Name  // read-write instance property
//        {
//            get => _name;
//            set => _name = value;
//        }

//        private int _counter;
//        public int Counter  // read-only instance property
//        {
//            get => _counter;
//        }

//        // constructor
//        public Employee() => _counter = ++numberOfEmployees;
//    }
//    internal class Interfaces
//    {
      
//        public static void Main()
//        {
//            System.Console.Write("Enter number of employees: ");
//            Employee.numberOfEmployees = int.Parse(System.Console.ReadLine());

//            Employee e1 = new Employee();
//            System.Console.Write("Enter the name of the new employee: ");
//            e1.Name = System.Console.ReadLine();

//            System.Console.WriteLine("The employee information:");
//            System.Console.WriteLine("Employee number: {0}", e1.Counter);
//            System.Console.WriteLine("Employee name: {0}", e1.Name);

//        }
     


//    }
//}
