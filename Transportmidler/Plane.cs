namespace Transportmidler
{
    class Plane : Vehicle
    {
        public Plane(string brand, string model, int maxSpeed) : base(brand, model, maxSpeed) { }
        public override void Drive() => Console.WriteLine($"The plane {Brand} {Model} flies in the sky.");
    }
}
