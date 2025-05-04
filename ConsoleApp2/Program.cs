// Implicitely typed variable
// var myFavoriteGenre = "RPG";

var myFavoriteNum = 11;

var yourFavoriteNum = 2;

// string ourNumCombined = myFavoriteNum + yourFavoriteNum;    // Doesn't work because it has to be int
var ourNumCombined = myFavoriteNum + yourFavoriteNum;
Console.WriteLine(ourNumCombined);

// Explicitely typed variable
// string myName = "Breno";

// Operators and Order of Evaluation
int num1 = 5;
int num2 = 13;

// Concatination
Console.WriteLine("Age is " + num1);
Console.WriteLine("Addition num1 + num2 = " + num1 + num2);

// Console.WriteLine("Addition num1 + num2 = " + num1 - num2);
// This line above gives the error: Operator '-' cannot be applied to operands of type 'string' and 'int'
// Because it would be -> 'Addition num1 + num2 = 5' - 13, which you cannot take a string and subtract it

// Order of Evaluation
Console.WriteLine("Subtractition num1 - num2 = " + (num1 - num2));
// Console.WriteLine("Subtractition num1 - num2 = 5" - num2);      // Same error above

Console.WriteLine("Multiplication num1 * num2 = " + num1 * num2);
Console.WriteLine("Division num1 / num2 = " + num1 / num2);
