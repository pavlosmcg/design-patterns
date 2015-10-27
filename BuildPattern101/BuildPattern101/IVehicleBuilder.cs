namespace BuildPattern101
{
    public interface IVehicleBuilder
    {
        VehicleBuilder WithNumberOfSeats(int numberOfSeats);
        VehicleBuilder WithEngineSize(int engineSize);
        VehicleBuilder WithColour(string colour);
        VehicleBuilder WithBootType(string bootType);
        VehicleBuilder WithNumberOfWheels(int numberOfWheels);
        Vehicle BuildVehicle();
    }
}