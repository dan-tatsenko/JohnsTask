using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    public class Car
    {
        public  int Id { get; set; }
        public string Make { get; set; }
        public  string  Model { get; set; }
        public string Colour { get; set; }

        public void PrintCar()
        {
            Console.WriteLine($"ID = {Id}, Make: {Make}, Model: {Model}, Colour: {Colour}");
        }
    }
}
