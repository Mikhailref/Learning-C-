//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;





//namespace ConsoleApp1.CodeWars
//{
//    public class Model1
//    {
//        public string name = "igor";

//    }
//    public class Model2 : Model1
//    {
//        public string adress = "ggg";
//    }



//    public class Class2
//    {

//        public static (string, List<string>) Return()
//        {

//            string input = "go";
//            List<string> list = new List<string>() { "go" };
//            list.Add(input);

//            return (input, list);
//        }


//        static void Main()
//        {



//            (string, List<string>) collection = Return();
//            Console.WriteLine(collection.Item1);
//            Console.WriteLine(collection.Item2);




//            Model1 model1 = new Model1();
//            Console.WriteLine(model1.name);
//            Model2 model2 = new Model2();
//            Console.WriteLine(model2.name);

//            List<int> list = new List<int>();
//            int one = 1;

//            for (int i = 0; i < 10; i++)
//            {
//                list.Add(one);
//            }

//            Console.WriteLine(list.Count);




//            //IEnumerable<int> myarray = Enumerable.Range(0, 4);
//            ////the same as int[] myarray = new int[] { 1, 2, 3 };

//            //IEnumerable Linq = from a in myarray where a == 1 select a;
//            ////or to shorten
//            //IEnumerable linqq = myarray.Where(a => a == 1);

//            //foreach (object l in linqq)
//            //{
//            //    Console.WriteLine(l);
//            //}


//            //char[] arr = { 'q', 'v' };
//            //string First = char.ToUpper(arr[0]).ToString();
//            //Console.WriteLine(First);
//            //// getting the first element
//            //char res = arr.First();
//            //char last = arr.Last();
//            //Console.WriteLine(res);
//            //Console.WriteLine(last);


//            //int d = 2; //route
//            //int e = 9; //number
//            //int f = 1;
//            //for (int i = d; i >= 1; i--)
//            //{
//            //    //insert some code
//            //}

//            //Console.WriteLine(Math.Sqrt(9));
//            //var root = Convert.ToInt32(Math.Pow(9, (1 / 2)));//does not work
//            //Console.WriteLine(root);

//        }



//    }
//}




