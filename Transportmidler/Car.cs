namespace Transportmidler
{
    class Car : Vehicle
    {
        public Car(string brand, string model, int maxSpeed) : base(brand, model, maxSpeed) { }
        public override void Drive() => Console.WriteLine($"The car {Brand} {Model} drives on the road.");
    }
}
