using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new CarFactory();
            factory.Cars.Add(new Car { Id = 0, Make = "Holden", Model = "Commadore SV6", Colour = "Red" });
            factory.Cars.Add(new Car { Id = 1, Make = "Mercedes", Model = "SLA250", Colour = "Grey" });
            factory.PrintCars();
        }
    }
}
