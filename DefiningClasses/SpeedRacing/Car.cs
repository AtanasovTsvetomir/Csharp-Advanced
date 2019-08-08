using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public  class Car
    {
        public Car (string model, double fuelAmount, double fuelConsimptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsimptionPerKm;

            TravelledDistance = 0;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }

        public double TravelledDistance { get; set; }


    }
}
