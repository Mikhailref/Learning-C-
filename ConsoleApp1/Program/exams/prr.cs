//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;



////
////
////




//using System.Collections;

//namespace ConsoleApp1.CodeWars
//{

//    public class Class2
//    {
//        static void Main()
//        {

//            //float a = 2.2f % 3f;
//            //Console.WriteLine(a);
//            //if (a != 0)
//            //{
//            //    Console.WriteLine(a);
//            //}


//            ////ТЕСТ ПРОБНЫЙ решил

//            //int n = 15;
//            //for (int i = 1; i <= n; i++)
//            //{
//            //    if (i % 3 == 0 && i % 5 == 0)
//            //    {
//            //        Console.WriteLine("FizzBuzz");
//            //    }
//            //    else if (i % 3 == 0 && i % 5 != 0)
//            //    {
//            //        Console.WriteLine("Fizz");
//            //    }
//            //    else if (i % 5 == 0 && i % 3 != 0)
//            //    {
//            //        Console.WriteLine("Buzz");
//            //    }
//            //    else if (i % 3 != 0 && i % 5 != 0)
//            //    {
//            //        Console.WriteLine(i);
//            //    }
//            //}


//            ////ТЕСТ 1 решил    
//            //List<int> arr = new List<int> { 0, -4, 2, 3, 4, 5, 6, 7, 8, 12, };
//            //int min = 5;
//            //int max = 7;

//            ////create filter where you delete all numbers that are above 7 or negative
//            //IEnumerable<int> arr1 = (from num in arr where num < 8 && num >= 0 select num).ToArray();
//            //int[] arr2 = (int[])arr1;

//            //////add any two nambers and count how many are inside ther range between l and r
//            //////l<=arr[1]+arr[2]<=r

//            //int result = 0;
//            //int sum;

//            //for (int i = 0; i < arr2.Length; i++)
//            //{
//            //    for (int j = i + 1; j < arr2.Length; j++)
//            //    {
//            //        sum = arr2[i] + arr2[j];
//            //        if (sum >= min && sum <= max)
//            //        {
//            //            result++;
//            //        }
//            //    }
//            //}
//            //Console.WriteLine(result);


//            //ТЕСТ 2 
//            //how many pairs in sum gives 3.0

//            List<double> list = new List<double> { 1.2, 1.8, 1.5, 1.6,1.5,1.7,2.4,0.8 };
            
//            double sum;
//            int result=0;
//            double num1;
//            double num2;
//            int index;
//            Dictionary<double,double> dictionary=new Dictionary<double,double>();

//            for (int i = 0; i < list.Count; i++)
//            {

//                for (int j = i+1 ; j < list.Count; j++)
//                {

//                    num1 = list[i] + list[j];
//                    num2 = list[i] + list[j+1];
                    
//                    if (num1 <= 3.0 && num2<=3.0 && num2<num1 )
//                    {
//                        Console.WriteLine(num1);
//                        index=j;
//                        dictionary.Add(index,num1);
//                    }
//                    else if (num1 <= 3.0 && num2 <= 3.0 && num2 > num1)
//                    {
//                        Console.WriteLine(num2);
//                        index = j+1;
//                        dictionary.Add(index, num2);
//                    }

//                }
//                dictionary.Clear();
//            }
//            Console.WriteLine(result);






//            //Hashtable MyHashtable = new Hashtable
//            //{
//            //    {3,"Three" },
//            //    {66,"another" }
//            //};
//            //MyHashtable.Add(5, "five");


//            //string Myvalue;
//            //for (int i = 100; i > 90; i--)
//            //{
//            //    MyHashtable.Add(i, $"number{i}");
//            //    Myvalue = (string)MyHashtable[i];

//            //    Console.WriteLine(Myvalue);
//            //}

//            //foreach (DictionaryEntry value in MyHashtable)
//            //{
//            //    Console.WriteLine($"Key:{value.Key}, Value;{value.Value}");
//            //}

//            //foreach (int key in MyHashtable.Keys)
//            //{
//            //    Console.WriteLine(key);
//            //}

//            //foreach (string value in MyHashtable.Values)
//            //{
//            //    Console.WriteLine(value);
//            //}

//        }




//    }

//}

