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

        // TODO : Implement the IVehicleBuilder Methods
    }
}