using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        public static int NumberOfCars { get; private set; } = 0;
        public List<Car> Cars { get; private set; }

        public CarLot()
        {
            Cars = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Cars.Add(car);
            NumberOfCars++;
            Console.WriteLine($"Number of cars in the lot: {NumberOfCars}");
        }

        public void PrintCarDetails()
        {
            foreach (Car car in Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}

