//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{

//   // Command Query Separation(CQS) is a design pattern that suggests
//   // that a method should either be a command that performs an action,
//   // or a query that returns data, but not both.This separation can
//   // lead to cleaner and more maintainable code.
//    public class Calculator
//    {
//        public int Result { get; private set; }

//        // Command: performs an action, but doesn't return anything
//        public void Add(int num)
//        {
//            Result += num;
//        }

//        // Command: performs an action, but doesn't return anything
//        public void Multiply(int num)
//        {
//            Result *= num;
//        }

//        // Query: returns data, but doesn't perform any action
//        public int GetResult()
//        {
//            return Result;
//        }
//    }

//}
