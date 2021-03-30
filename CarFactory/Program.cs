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
            factory.Cars.Add(new Car { Id = 2, Make = "Holden", Model = "Commadore SV6", Colour = "Black" });
            factory.Cars.Add(new Car { Id = 3, Make = "Nissan", Model = "Juke", Colour = "Yellow" });
            factory.Cars.Add(new Car { Id = 4, Make = "Nissan", Model = "Leaf", Colour = "White" });
            factory.Cars.Add(new Car { Id = 5, Make = "Nissan", Model = "Leaf", Colour = "Black" });
            factory.Cars.Add(new Car { Id = 6, Make = "Nissan", Model = "Juke", Colour = "White" });
            factory.PrintCars();
            factory.Cars = factory.FilterByMake("Mercedes");
            factory.PrintCars();
        }
    }
}
