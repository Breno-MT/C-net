namespace Fields;

class Program
{
    // Field (or instance variable) - sometimes even called global variables
    int myResult;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number, I will add 10 to it!");
        int num1 = int.Parse(Console.ReadLine());

        int myResult = AddTwoValues(num1, 10);
        Console.WriteLine("The result is {0}", myResult);

        Console.WriteLine("Now i will subtract 5 from it!");
        int myResult2 = SubtractTwoValues(myResult, 5);
        Console.WriteLine("The result is {0}", myResult2);
    }

    static int AddTwoValues(int value1, int value2) {
        int myResult = value1 + value2;
        return myResult;
    }

    static int SubtractTwoValues(int value1, int value2) {
        int myResult = value1 - value2;
        return myResult;
    }
}
