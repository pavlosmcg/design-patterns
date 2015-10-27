namespace BuildPattern101
{
    // A FACTORY EXAMPLE....
    public abstract class VehicleFactory
    {
        public Vehicle CreateVehicle(int seats, int engineSize, string colour, string bootType, int wheels)
        {
            var vehicle = new Vehicle();
            vehicle.Seats = seats;
            vehicle.EngineSize = engineSize;
            vehicle.Colour = colour;
            vehicle.BootType = bootType;
            vehicle.Wheels = wheels;
            return vehicle;
        }
    }
}