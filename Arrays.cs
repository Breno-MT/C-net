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
