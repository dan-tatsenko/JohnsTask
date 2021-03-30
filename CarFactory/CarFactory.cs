using System;
using System.Collections.Generic;
using System.Text;

namespace CarFactory
{
    class CarFactory
    {
        public CarFactory()
        {
            Cars = new List<Car>();
        }

        public List<Car> Cars { get; set; }
        public void PrintCars()
        {
            foreach (Car c in Cars)
            {
                c.PrintCar();
            }
        }
    }
}
