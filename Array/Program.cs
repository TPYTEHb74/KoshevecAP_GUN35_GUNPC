//Задание 1
using System.Runtime.ExceptionServices;

Console.WriteLine("Task 1");
int Fib(int n)
{
    if ((n == 0) || (n == 1))
        return n;
    return Fib(n - 1) + Fib(n - 2);
}
Console.WriteLine($"{Fib(0)}, {Fib(1)}, {Fib(2)}, {Fib(3)}, {Fib(4)}, {Fib(5)}, {Fib(6)}, {Fib(7)}, {Fib(8)}");


//Задание 2
Console.WriteLine("Task 2");
string[] mounths = new string[12] { "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December" };
Console.WriteLine(string.Join(", ", mounths));


//Задание 3
Console.WriteLine("Task 3");
int[][] ints = new int[3][];
ints[0] = new int[3];
ints[1] = new int[3];
ints[2] = new int[3];

foreach (var f in ints)
    Console.WriteLine("{0} в квадрате равно {1}", f,  f * f);




//Задание 4
Console.WriteLine("Task 4");
int u = 0;
 int[][] myArr = new int[3][];
 myArr[0] = new int[6];
 myArr[1] = new int[2];
 myArr[2] = new int[4];

for (u = 0; u < 6; u++)
{
    myArr[0][u] = u;
    Console.Write("{0}\t", myArr[0][u]);
}
Console.WriteLine();

for (u = 0; u < 2; u++)
{
    myArr[1][u] = u;
    Console.Write("{0}\t", myArr[1][u]);
}
Console.WriteLine();

for (u = 0; u < 4; u++)
{
    myArr[2][u] = u;
    Console.Write("{0}\t", myArr[2][u]);
}
Console.WriteLine();
 

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




