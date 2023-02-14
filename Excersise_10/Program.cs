// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Enter 3-digit number");
int a = int.Parse(Console.ReadLine()!);

if ( a < 1000 && a > 99 )
{
    int a3 = a % 10;
    int a1 = a / 100;
    int a2 = (a - a1 * 100 - a3)/10;
    Console.WriteLine("The 2nd digit is:" + a2);
}

else
Console.WriteLine("This is not a 3-digit number");