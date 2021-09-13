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

                        carperson.Add(new Car() { Name = name, Color = color, Age = age, Exhaustpipe = exhaustpipe, Price = price, Model = model });
                        Console.Clear();

                        break;



                    case "e":
                       
                        

                        break;


                    case "d":

                        foreach (Car c in carperson)
                        {
                            Console.WriteLine($"{c.Name} {c.Age} {c.Model} {c.Exhaustpipe} {c.Price}");
                        }

                        Console.WriteLine("skriv in nummer på bilen du vill ta bort från listan");
                        int i = Convert.ToInt32(Console.ReadLine()); 
                        carperson.RemoveAt(i - 1);
                        Console.WriteLine("_______________________________________________");

                        foreach (Car c in carperson)
                        {
                            Console.WriteLine($"{c.Name} {c.Age} {c.Model} {c.Exhaustpipe} {c.Price}");
                        }
                            
                        break;
                        


                    case "s":


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
