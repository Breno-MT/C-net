namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        Car bmw = new Car("318i", "Bmw", true);
        Car audi = new Car("RS6", "Audi", false);

        Console.WriteLine("Please type the Brand name:");
        // Setting Brand
        // audi.Brand = Console.ReadLine();

        // Getting Brand
        Console.WriteLine("You entered: {0}", audi.Brand);
    }
}
