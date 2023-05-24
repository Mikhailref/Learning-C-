//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////https://www.codewars.com/kata/58b1ae711fcffa34090000ea/train/csharp

//namespace ConsoleApp1.CodeWars._40_50
//{

//    public class Door 
//    {
//        public char Signal { get; set; } //'.' 'p' 'o'
//        public int State { get; set; }//0-none 1-opening 2-closing 

//        public string Paused { get; set; }//yes no

//        public Door()
//        {
//        }
//    }


//    public class Program
//    {
//        public static void Main()
//        {
//            string events = "P..OP..P..";
//            ProcessEvents(events);
//        }
//        public static string ProcessEvents(string events)
//        {

//            Door door = new Door();

//            char[] array=events.ToCharArray();

//            int Digit = 0;
//            door.State = 0;
//            door.Paused = "no";


//            string result = string.Empty;

//            for (int i=0; i<array.Length; i++)
//            {
//                door.Signal = array[i];

//                //start
//                if(door.Signal == '.' && door.State==0 && door.Paused == "no" && Digit==0)
//                {
//                    door.State = 0;
//                    Digit = 0;
//                }

//                //to open
//                else if(door.Signal == 'P' && door.State==0 && door.Paused=="no" && Digit==0)
//                {
//                    door.State=1;
//                    Digit = 1;
//                }

//                //opening
//                else if (door.Signal == '.' && door.State == 1 && door.Paused == "no" && Digit<5)
//                {
//                    door.State = 1;
//                    Digit++;
//                }

//                //is open
//                else if(door.Signal == '.' && door.State == 1 && door.Paused == "no" && Digit == 5)
//                {
//                    door.State = 0;
//                    Digit = 5;
//                }

//                //to close
//                else if (door.Signal == 'P' && door.State == 0 && door.Paused == "no" && Digit == 5)
//                {
//                    door.State = 2;
//                    Digit --;
//                }

//                //closing
//                else if (door.Signal == '.' && door.State == 2 && door.Paused == "no" && Digit >0)
//                {
//                    door.State = 2;
//                    Digit--;
//                }

//                //is closed
//                else if (door.Signal == '.' && door.State == 2 && door.Paused == "no" && Digit == 0)
//                {
//                    door.State = 0;
//                    Digit=0;
//                }


//                //to pause
//                else if (door.Signal == 'P' && door.State == 1 && door.Paused == "no" && Digit < 5)
//                {
//                    door.Paused = "yes";
//                    Digit = Digit;
//                }

//                else if (door.Signal == '.' && door.State == 1 && door.Paused == "yes" && Digit < 5)
//                {
//                    door.Paused = "yes";
//                    Digit = Digit;
//                }

//                else if (door.Signal == 'P' && door.State == 1 && door.Paused == "yes" && Digit < 5)
//                {
//                    door.Paused = "no";
//                    Digit++;
//                }

//                //obstacle
//                else if (door.Signal == 'O' && door.State == 1 )
//                {
//                    door.State = 2;
//                    Digit--;
//                }

//                else if (door.Signal == 'O' && door.State == 2)
//                {
//                    door.State = 1;
//                    Digit++;
//                }

//                //obstacle and pause
//                else if (door.Signal == 'P' && door.State == 1 && door.Paused == "no" && Digit < 5)
//                {
//                    door.Paused = "yes";
//                    Digit = Digit;
//                }
              


//                result =result+Digit.ToString();
                

//                //Console.WriteLine(Digit);

//            }

//            Console.WriteLine(result);

//            return result;

           
//        }

         
    
//    }


//}
