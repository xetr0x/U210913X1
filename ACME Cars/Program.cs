using System;
using System.Collections.Generic;

namespace ACME_Cars
{
    class Program
    {
       

        static void Main(string[] args)
        {
            List<Car> carperson = new List<Car>();
            
            while (true)
            {
                Console.WriteLine("X = Exit | N = Add car | E = Edit car | D = Remove car | S = Show all cars");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "x" :
                        
                        break;


                    case "n":
                       
                        break;



                    case "e":
                       
                        break;


                    case "d":
                       
                        break;


                    case "s":
                        
                        break;
                }



                Console.Clear();
            }

        }
        
        class Car
        {
           public string Color;
           public string Model;
           public string Price;
           public string Age;
           public string Exhaustpipe;
        } 
    }
}
