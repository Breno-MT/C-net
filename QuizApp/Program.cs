// User Answers
// Questions
// Score a point in case user get it right!

int score = 0;

Console.WriteLine("What's the color of the sky?");
string answer1 = "Blue";
string userAnswer1 = Console.ReadLine();

if (userAnswer1.Trim().ToLower() == answer1.ToLower()) {
    Console.WriteLine("You got it right!");
    score++;
}

else {
    Console.WriteLine("You got it wrong :(");
}

Console.WriteLine ("What's 11*11?");
int answer2 = 121;
int userAnswer2 = int.Parse(Console.ReadLine());

if (userAnswer2 == answer2) {
    Console.WriteLine("Nice! It's correct!");
    score++;
}

else {
    Console.WriteLine("Nope, that's not it :/");
}

Console.WriteLine("Last question! What's the capital of Brasil?");
string answer3 = "Brasilia";
string userAnswer3 = Console.ReadLine();

if (userAnswer3.Trim().ToLower() == answer3.ToLower()) {
    Console.WriteLine("Correct! You got it right!");
    score++;
}

else {
    Console.WriteLine("Aw man! That's too bad, that's simple not it :/");
}

Console.WriteLine("Thanks for playing! Now the results is....");
Console.WriteLine("You got it {0} out of 3!", score);

switch (score) {
    case 1:
        Console.WriteLine("Well, you got it one at least!");
        break;
    case 2:
        Console.WriteLine("Almost 3! So close bro");
        break;
    case 3:
        Console.WriteLine("You surely are the boss! Well done mate! :)");
        break;
    default:
        Console.WriteLine("It's alright... somewhat you tried... :(");
        break;
}
