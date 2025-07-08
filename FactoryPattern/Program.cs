namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle need?");
            var numberOfWheels = Console.ReadLine();

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();
        }
    }
}
