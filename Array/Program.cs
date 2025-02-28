//Задание 1
using System.Runtime.ExceptionServices;

Console.WriteLine("Task 1");
int[] Fib = new int[] { 0, 1, 2, 3, 5, 8, 13, 21 };
Fib.ToList().ForEach(i => Console.WriteLine(i.ToString()));


//Задание 2
Console.WriteLine("Task 2");
string[] mounths = new string[12] { "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December" };
Console.WriteLine(string.Join(", ", mounths));


//Задание 3
Console.WriteLine("Task 3");
int[,] ints = { {2, 3, 4 }, {4, 9, 16 }, {8, 27, 64 }};

int rows = ints.GetUpperBound(0) + 1;
int columns = ints.Length / rows;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{ints[i, j]} \t");
    }
    Console.WriteLine();
}


//Задание 4
Console.WriteLine("Task 4");
const double PI = Math.PI;
const double E = Math.E;

double[][] myArr = new double[3][]
 {
    new double[] { 1, 2, 3, 4, 5 },
    new double[] {PI, E },
    new double[] { Math.Log10(1), Math.Log10(10), Math.Log10(100), Math.Log10(1000) }
 };

for (int i = 0; i < myArr.Length; i++)
{
    for (int j = 0; j < myArr[i].Length; j++)
    {

        Console.Write($"{myArr[i][j]} \t");
    }
    Console.WriteLine();
}


//Задание 5
Console.WriteLine("Task 5");
int[] array = new int[] { 1, 2, 3, 4, 5 };
int[] array2 = new int[] { 7, 8, 9, 10, 11, 12, 13 };

Array.Copy(array, 1, array2, 0, 3);

foreach (var number in array2)
    Console.Write($"{number}, ");
Console.WriteLine();


//Задание 6
Console.WriteLine("Task 6");
Array.Resize(ref array, 10);
foreach (var number in array)
    Console.Write($"{number}, " );




