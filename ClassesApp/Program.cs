﻿namespace ClassesApp;

class Program
{
    static void Main(string[] args)
    {
        // Car bmw = new Car("318i", "Bmw", true);
        // Car audi = new Car("RS6", "Audi", false);

        // Console.WriteLine("Please type the Brand name:");
        // // Setting Brand
        // // audi.Brand = Console.ReadLine();

        // // Getting Brand
        // Console.WriteLine("You entered: {0}", audi.Brand);

        // Customer bento = new Customer("Bento");
        // Customer jota = new Customer("Jotinha", "Xique-xique Bahia", "02913102231");

        // // Default Customer
        // Customer guest = new Customer();

        // Console.WriteLine(bento.Name);
        // Console.WriteLine("Hello! This is {0} and his number {1}", jota.Name, jota.ContactNumber);
        // Console.WriteLine("Hello, {0}!", guest.Name);
        // Console.Write("Type your name: ");
        // guest.Name = Console.ReadLine();
        // Console.WriteLine("Hello, {0}!", guest.Name);

        Car myBmw = new Car("318i", "BMW", false);
        myBmw.Drive();

        Customer customer = new Customer();
        customer.SetDetails("Nick", "Where");
        Console.WriteLine("{0} {1} {2}", customer.Name, customer.Address, customer.ContactNumber);

        Customer customer1 = new Customer("Oliver");
        Console.WriteLine("{0} {1} {2}", customer1.Name, customer1.Address, customer1.ContactNumber);

        // Named Parameters
        static int AddNum(int firstNum, int secondNum) {
            return firstNum + secondNum;
        }
        int result = AddNum(firstNum: 15, secondNum: 15);
        Console.WriteLine(result);

    }
}
