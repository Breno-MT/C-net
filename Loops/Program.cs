namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        // This Loop will count down from 10 to 1
        // To include 0 on this list, just change to: i >= 0
        for (int i = 10; i > 0; i--) {
            Console.WriteLine(i);
            // Makes the system wait 1sec before decrementing again
            // Thread.Sleep(1000);
        }

        int counter = 0;
        while (counter < 11) {
            Console.WriteLine(counter);
            counter++;
        }
    }
}
