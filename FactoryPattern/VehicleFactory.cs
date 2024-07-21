namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle? GetVehicle()
    {
        Console.WriteLine("How many wheels does the vehicle have?");
        var isInt = int.TryParse(Console.ReadLine(), out int numberOfWheels);
        if (!isInt || (numberOfWheels!=2 && numberOfWheels!=4))
        {
            Console.WriteLine("Invalid input. Please restart and try again.");
            return null;
        }

        if (numberOfWheels == 2) return new Motorcycle();
        return new Car();

    }
}