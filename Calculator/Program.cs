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
Console.WriteLine($"The sum of this two numbers are: {sum}");

// Implicity conversion
int myInt1 = 12;
double myInt2 = myInt1;
long myLong = myInt1;
//

//
float myFloat = 123.123f;
double myDouble = 13.2123123123;
// Explicity conversion
myFloat = (float)myDouble;
Console.WriteLine(myFloat);

// Explicity casting
int isInt;
double myDouble3 = 13.5;
isInt = (int)myDouble3;
Console.WriteLine(isInt);

// Conversion Helpers Parse and Convert
string numberString = "123";
int result = int.Parse(numberString);
Console.WriteLine(result);


string myBoolString = "true";
bool myBool = Convert.ToBoolean(myBoolString);
Console.WriteLine(myBool);
