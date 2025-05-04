// try Parse
Console.WriteLine("Gimme a number: ");
string userInput = Console.ReadLine();
int num1 = int.Parse(userInput);

bool isNumber = int.TryParse(userInput, out num1);

if (isNumber) {
    Console.WriteLine("It is a number.");
}

else {
    Console.WriteLine("You tried, but enter a number next time.");
}

num1++;
Console.WriteLine("User entered number +1 " + num1);

// random class
Random random = new Random();
// This will get us a random number between 1 and 10
int randomNumber = random.Next(1,11);
Console.WriteLine("Guess the number bro (1-10):");
int userAnswer1 = int.Parse(Console.ReadLine());

// You can debug it to see the number that has been generated hehe
if (userAnswer1 == randomNumber) {
    Console.WriteLine("Nice guess! It's correct! The number was {0}!", randomNumber);
}

else {
    Console.WriteLine("Well, you tried");
}
