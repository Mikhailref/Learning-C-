//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////hashtable
////dictionary

//namespace ConsoleApp1.CodeWars
//{
//    internal class Class1
//    {
//        public static void Main()
//        {
//            //Console.WriteLine("go"+"\n\t"+"go");
//            //n means new line
//            //t means tab-spase

//            //1
//            //create a hashtable
//            Hashtable MyHashtable = new Hashtable
//            {
//                {"Three",3 },
//                {"another",234 }
//            };
//            MyHashtable.Add("five", 5);

//            //search by key value
//            int Value = (int)MyHashtable["Three"];

//            //this will not work because only the first row has a key value
//            string Value2 = (string)MyHashtable[3];

//            Console.WriteLine(Value+Value2);
//            Console.WriteLine("===========create a hashtable ===================");


//            //2
//            //create a dictionary
//            Dictionary<int, string> MyDictionary = new Dictionary<int,string>
//            {
//                {3,"Three"},
//                {234,"another"}
//            };
//            MyDictionary.Add(5,"five");

//            //3
//            //create a hashtable from the dictionary
//            Hashtable MyHashDict = new Hashtable(MyDictionary);
//            string ValueOf3 = (string)MyHashDict[3];

//            Console.WriteLine(ValueOf3);

//            MyHashDict.Add(55, "fifty five");

//            string ValueOf55 = (string)MyHashDict[55];

//            //you have to put Remove befor initializing a string ValueOf55
//            //otherwise the valueof55 will stay in the memory even if
//            //the value itself deleted from a dictionary
//            MyHashDict.Remove(55);

//            Console.WriteLine(ValueOf55);

//            //bool
//            MyHashDict.ContainsKey(55);
//            MyHashDict.ContainsValue(55);
//            bool check= MyHashDict.Contains(55);
//            Console.WriteLine(check);
            

//            Console.WriteLine("11111======================");

//            //use var/DictionaryEntry in Hashtable or dictionaries converted to Hashtable
//            foreach (DictionaryEntry value in MyHashDict)
//            {
//                Console.WriteLine($"Key:{value.Key}, Value;{value.Value}");
//            }

//            Console.WriteLine("1a1a1a1a1======================");
            
//            Dictionary<int, string> Dictionary = new Dictionary<int, string>
//            {
//                {3,"Three" },
//                {5,"another"}
//            };

//            ////use var/???? in dictionaries
//            foreach (var value in Dictionary)
//            {
//                Console.WriteLine($"Key:{value.Key}, Value;{value.Value}");
//            }



//            Console.WriteLine("22222======================");

//            foreach (int value in MyHashDict.Keys)
//            {
//                Console.WriteLine(value);
//            }

//            Console.WriteLine("3333======================");

//            foreach (string value in MyHashDict.Values)
//            {
//                Console.WriteLine(value);
//            }

           




//        }

//    }
//}
