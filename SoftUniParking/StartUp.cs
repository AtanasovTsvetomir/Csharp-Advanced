namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Parking parking = new Parking(2);

            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");

            System.Console.WriteLine(parking.AddCar(car));
            System.Console.WriteLine(parking.RemoveCar(car.RegistrationNumber));
        }
    }
}
