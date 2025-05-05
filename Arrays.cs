// Declare an array (must say how many numbers inside that array, in this case will be 5)
int[] myIntArray = new int[5];

// Or declare it with the values already in it
int[] myIntArray2 = [5,12,55,16,19];
// some previous versions of C# requires the array to be initialized using braces instead of brackets
// int[] myIntArray2 = {5,12,55,16,19}
// changing from [] to {}

string[] weekDays = ["Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"]

// 2D array
int[,] array2D = new int[3, 3];
// [0] [0]
// [0] [0]

string[,] understandingIndexes = 
{
    {"0,0", "0,1", "0,2"},
    {"1,0", "1,1", "1,2"},
    {"2,0", "2,1", "2,2"},
};

int[,] array2D = {{1,2}, {3,4}};
Console.WriteLine(array2D[0,1]);        // The first[] is the row, the second[] is the column


// 3D Array
int[,,] array3DDeclaration = new int[3, 3, 3];

string[,,] simple3DArray =
{
    {
        {"000", "001"},
        {"010", "011"},
    },
    {
        {"100", "101"},
        {"110", "111"},
    },
    {
        {"200", "201"},
        {"210", "211"},
    }
};

Console.WriteLine(simple3DArray[2,1,0]) // output: 210

/*
Create a simple C# program that initializes a 3x3 two-dimensional array with integers, calculates the sum of each row, and prints the sums to the console.

The program should:

Declare and initialize a 3x3 two-dimensional array with the following values:
1 2 3
4 5 6
7 8 9
Calculate the sum of each row in the array.

Print the sum of each row to the console.

Alert!

The result of execution for the default string should be:

6
15
24
*/
int[,] array1 = {{1,2,3}, {4,5,6}, {7,8,9}};
for (int i = 0; i < 3; i++) 
    {
        int sum = 0; // Initialize the sum variable for the current row
        
        // Loop through each column in the current row
        for (int j = 0; j < 3; j++) 
        {
            sum += array1[i, j]; // Add the element to the sum
        }
        
        // Print the sum of the current row
        Console.WriteLine(sum); 
    }
