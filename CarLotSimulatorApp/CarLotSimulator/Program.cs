using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car(2006, "Ford", "Bronco", "Vroom", "Honk", true);

            Car car2 = new Car() { Year = 2009, Make = "Jeep", Model = "Patriot", EngineNoise = "Vrr Vroom", HonkNoise = "Quack", IsDriveable = true };

            Car car3 = new Car();

            car3.Year = 2001;
            car3.Make = "Honda";
            car3.Model = "Civic";
            car3.EngineNoise = "VRRRRRRRRRR";
            car3.HonkNoise = "Beep";
            car3.IsDriveable = true;

            Console.WriteLine($"{car1.Make} {car1.Model}");
            Car.MakeHonkNoise($"Honk Noise: {car1.HonkNoise}");
            Car.MakeEngineNoise($"Engine Noise: {car1.EngineNoise}\n");

            Console.WriteLine($"{car2.Make} {car2.Model}");
            Car.MakeHonkNoise($"Honk Noise: {car2.HonkNoise}");
            Car.MakeEngineNoise($"Engine Noise: {car2.EngineNoise}\n");

            Console.WriteLine($"{car3.Make} {car3.Model}");
            Car.MakeHonkNoise($"Honk Noise: {car3.HonkNoise}");
            Car.MakeEngineNoise($"Engine Noise: {car3.EngineNoise}\n");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
