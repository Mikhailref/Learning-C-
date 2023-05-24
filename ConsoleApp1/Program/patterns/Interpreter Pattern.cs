//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1.Program.patterns
//{

//    //Suppose you have a grammar for simple mathematical expressions,
//    //such as "2 + 3 * 4"
//    // and you want to interpret and evaluate them programmatically.
//    public abstract class Expression
//    {
//        public abstract int Interpret();
//    }

//    public class Number : Expression
//    {
//        private int _value;

//        public Number(int value)
//        {
//            _value = value;
//        }

//        public override int Interpret()
//        {
//            return _value;
//        }
//    }

//    public class Add : Expression
//    {
//        private Expression _left;
//        private Expression _right;

//        public Add(Expression left, Expression right)
//        {
//            _left = left;
//            _right = right;
//        }

//        public override int Interpret()
//        {
//            return _left.Interpret() + _right.Interpret();
//        }
//    }

//    public class Multiply : Expression
//    {
//        private Expression _left;
//        private Expression _right;

//        public Multiply(Expression left, Expression right)
//        {
//            _left = left;
//            _right = right;
//        }

//        public override int Interpret()
//        {
//            return _left.Interpret() * _right.Interpret();
//        }
//    }

//    public class Client
//    { 
//      public static void Main(string[] args) 
//        {
//            Expression Addexpression = new Add( new Number(2),new Multiply( new Number(3),new Number(4)));
//            Console.WriteLine(Addexpression.Interpret()); // result = 14); 


//            Number number1 = new Number(2);
//            Number number2 = new Number(4);
//            Number number3 = new Number(5);
//            Expression AddNumbers = new Add(number1, number2);
//            Expression Multiplay = new Multiply(number3,AddNumbers);
//            Console.WriteLine(Multiplay.Interpret());

//        }
//    }


//}
