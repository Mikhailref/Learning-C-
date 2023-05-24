//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////You are working on a project where you need to parse
////different types of data files (CSV, JSON, XML, etc.)
////and extract relevant information from them.
////Which design pattern would you use to encapsulate
////the parsing logic and provide a uniform interface
////for clients to access the extracted data?

//namespace ConsoleApp1.Program.YouTube
//{
//    internal class Design_Pattern_s_Scenario
//    {
//        interface IParser
//        {
//            string Parse(string File);
//        }

//        class CSVparser : IParser
//        {
//            public string Parse(string File)
//            {
//                return "The extracted data from CSV file";
//            }
//        }

//        class JSONparser : IParser
//        {
//            public string Parse(string File)
//            {
//                return "The extracted data from JSON file";
//            }
//        }

//        class XMLparser : IParser
//        {
//            public string Parse(string File)
//            {
//                return "The extracted data from XML file";
//            }
//        }

//        class DataParser
//        {
//            private IParser _parser;
//            public DataParser(IParser parser)
//            {
//                _parser = parser;
//            }

//            public string Execute(string File)
//            {
//                return _parser.Parse(File);
//            }
//        }

//        class Client
//        { 
//          public static void Main()
//            {
//                DataParser dataParser=new DataParser(new XMLparser());
//                Console.WriteLine(dataParser.Execute("File XML"));
//                dataParser=new DataParser(new JSONparser());
//                Console.WriteLine(dataParser.Execute("File Json"));
//            }
//        }


//    }
//}
