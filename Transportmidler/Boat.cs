namespace Transportmidler
{
    class Boat : Vehicle
    {
        public Boat(string brand, string model, int maxSpeed) : base(brand, model, maxSpeed) { }
        public override void Drive() => Console.WriteLine($"The boat {Brand} {Model} sails on the water.");
    }
}
