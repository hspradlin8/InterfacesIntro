namespace InterfacesIntro
{
    public class Cessna : IVehicle, IGasVehicle
    {
        public int FuelCapacity { get; set; }
        public int FuelLevel { get; set; }

        public void Drive()
        {
            Console.WriteLine("Zoom!");
        }

        public void RefuelTank()
        {
            FuelLevel = FuelCapacity;
        }
    }
}