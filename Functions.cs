// Functions
// void means that this function can return nothing
void AddNumbers(int num1, int num2) {
    int result = num1 + num2;
}

// In this case, it has to return something
// static makes not necessary to instance the class to use it
// e.g: public class Calculator ... float SubNumbers (in this case you would need to -> Calculator myCalc = new Calculator() )
// and then myCalc.SubNumbers();
// with static you should just use subNumbers(), simple as that. Inside the scope that is.
static int SubNumbers(int num1, int num2) {
    int result = num1 - num2;
    return result;
}

/*
✅ Use ref when you need a method to modify an existing variable.

✅ Use out when you need a method to return multiple values.

✅ Use in when passing large objects that should not be modified.
*/

// REF
void ModifyValue(ref int number)
{
    number += 10; // Modify the original value
}
 
int myNumber = 5;
ModifyValue(ref myNumber);
Console.WriteLine(myNumber); // Output: 15

// OUT
void GetValues(out int result)
{
    result = 42; // Must be assigned before the method exits
}
 
int myValue;
GetValues(out myValue);
Console.WriteLine(myValue); // Output: 42

// IN
void Calculate(int x, int y, out int sum, out int product)
{
    sum = x + y;
    product = x * y;
}
 
int a = 5, b = 3, sum, product;
Calculate(a, b, out sum, out product);
Console.WriteLine($"Sum: {sum}, Product: {product}");
// Output: Sum: 8, Product: 15
