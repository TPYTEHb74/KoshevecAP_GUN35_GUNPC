// See https://aka.ms/new-console-template for more information

//Задание 1
Console.WriteLine("task 1");

int val1 = 0, val2 = 1, val3, i, n = 10;
Console.Write("The first ten Fibonacci numbers:");
Console.WriteLine(val1 + " " + val2 + " ");
for (i = 2; i < n; ++i)
{
    val3 = val1 + val2;
    Console.WriteLine(val3 + " ");
    val1 = val2;
    val2 = val3;
}


//Задание 2
Console.WriteLine("task 2");


int nom = 20;

for (int o = 2; o <= nom; o +=2 )
{
    Console.WriteLine(o);
}


//Задание 3
Console.WriteLine("task 3");
int num = 1, num1 = 1;
    
for( num = 1; num <= 5; num++ )
{
    Console.WriteLine("\t");
    for(num1 = 1; num1 <= 5;  num1++ )
    {
        Console.Write("{0}\t", num * num1);
    }
}
Console.WriteLine();


//Задание 4
Console.WriteLine("task 4");

string password = "qwerty";
int result = 0;

do
{
    Console.WriteLine("Enter the password");
    string checkPassword = Console.ReadLine();
    if (checkPassword == password)
    {
        Console.WriteLine("Welkome");
        Console.ReadLine();
        break;
    }
    Console.WriteLine("The password is incorrect");
}
while (result > 6);


