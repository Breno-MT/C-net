// try Parse
Console.WriteLine("Gimme a number: ");
string userInput = Console.ReadLine();
int num1 = int.Parse(userInput);

bool isNumber = int.TryParse(userInput, out num1);

if (isNumber) {
    Console.WriteLine("It is a number.")
}

else {
    Console.WriteLine("You tried, but enter a number next time.");
}

num1++;
Console.WriteLine("User entered number +1 " + num1);
