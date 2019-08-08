using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carsData = Console.ReadLine().Split();

                string carModel = carsData[0];
                double fuelAmount = double.Parse(carsData[1]);
                double fuelConsumptionPerKm = double.Parse(carsData[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsumptionPerKm);

                Console.WriteLine(car.Model);
                Console.WriteLine(car.FuelAmount);
                Console.WriteLine(car.FuelConsumptionPerKm);
            }

            
        }
    }
}
