﻿using System;
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

                        Console.WriteLine("Mata in namnet på bilen: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Mata in färgen på bilen: ");
                        string color = Console.ReadLine();
                        Console.WriteLine("Mata in ålder på din bil: ");
                        string age = Console.ReadLine();
                        Console.WriteLine("Mata in modell av din bil: ");
                        string model = Console.ReadLine();
                        Console.WriteLine("Mata in priset på din bil: ");
                        string price = Console.ReadLine();
                        Console.WriteLine("Mata in diametern på ditt avgasrör: ");
                        string exhaustpipe = Console.ReadLine();
                        
                        


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
            public string Name;
           public string Color;
           public string Model;
           public string Price;
           public string Age;
           public string Exhaustpipe;
        } 
    }
}
