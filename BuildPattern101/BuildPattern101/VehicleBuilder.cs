namespace BuildPattern101
{
    // THE CONCRETE BUILDER
    public class VehicleBuilder : IVehicleBuilder
    {
        private int Seats { get; set; }
        private int EngineSize { get; set; }
        private string Colour { get; set; }
        private string BootType { get; set; }
        private int Wheels { get; set; }

        public VehicleBuilder WithNumberOfSeats(int numberOfSeats)
        {
            Seats = numberOfSeats;
            return this;
        }

        public VehicleBuilder WithEngineSize(int engineSize)
        {
            EngineSize = engineSize;
            return this;
        }

        public VehicleBuilder WithColour(string colour)
        {
            Colour = colour;
            return this;
        }

        public VehicleBuilder WithBootType(string bootType)
        {
            BootType = bootType;
            return this;
        }

        public VehicleBuilder WithNumberOfWheels(int numberOfWheels)
        {
            Wheels = numberOfWheels;
            return this;
        }

        public Vehicle BuildVehicle()
        {
            var vehicle = new Vehicle();
            vehicle.BootType = BootType;
            vehicle.Colour = Colour;
            vehicle.EngineSize = EngineSize;
            vehicle.Seats = Seats;
            vehicle.Wheels = Wheels;
            return vehicle;
        }
    }
}