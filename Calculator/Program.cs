// See https://aka.ms/new-console-template for more information
using System.Globalization;

double number1 = 0.0;
double number2 = 0.0;

Console.WriteLine("Enter a number below:");
string userInput = Console.ReadLine();
number1 = double.Parse(userInput, CultureInfo.InvariantCulture);

Console.WriteLine("Good, now a second number:");
string userInput2 = Console.ReadLine();
number2 = double.Parse(userInput2, CultureInfo.InvariantCulture);       // Some countries use comma instead of dot

double sum = number1 + number2;
sum = Math.Round(sum, 2);

// Implicity conversion
int myInt1 = 12;
double myInt2 = myInt1;
long myLong = myInt1;

Console.WriteLine($"The sum of this two numbers are: {sum}");

