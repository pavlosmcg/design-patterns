using System;

namespace BuildPattern101
{
    class Program
    {
        // THE DIRECTOR
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Creating new vehicle");

            var vehicleBuilder = new VehicleBuilder()
                .WithBootType("Saloon")
                .WithColour("Red")
                .WithEngineSize(1800)
                .WithNumberOfSeats(2)
                .WithNumberOfWheels(4);
            var vehicle = vehicleBuilder.BuildVehicle();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("You have created a vehicle with: ");
            Console.WriteLine(vehicle.BootType + " boot,");
            Console.WriteLine(vehicle.Colour + " colour,");
            Console.WriteLine(vehicle.EngineSize + " engine size,");
            Console.WriteLine(vehicle.Seats + " seats,");
            Console.WriteLine(vehicle.Wheels + " wheels.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();
        }
    }
}
