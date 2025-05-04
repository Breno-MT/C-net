namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        // This Loop will count down from 10 to 1
        // To include 0 on this list, just change to: i >= 0
        // for (int i = 10; i > 0; i--) {
        //     Console.WriteLine(i);
        //     // Makes the system wait 1sec before decrementing again
        //     // Thread.Sleep(1000);
        // }

        // int counter = 0;
        // while (counter < 11) {
        //     Console.WriteLine(counter);
        //     counter++;
        // }

        // Foreach is the best option when you want to see, manipulate, etc... data inside an array of objects (or just an array like this)
        string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"];

        foreach (var day in weekDays)
        {
            Console.WriteLine(day);
        }
    }
}
