namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = VehicleFactory.GetVehicle();
            if (vehicle != null ) vehicle.Drive();
        }
    }
}
