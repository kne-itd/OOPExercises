namespace Transportmidler
{
    abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public int FuelLevel { get; private set; }

        public Vehicle(string brand, string model, int maxSpeed)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public void FuelUp(int liters)
        {
            FuelLevel += liters;
            Console.WriteLine($"{Brand} {Model} fueled up. Current fuel: {FuelLevel} liters.");
        }

        public abstract void Drive();
    }
}
