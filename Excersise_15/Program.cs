// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Please enter the nubber of the week day ");
int day = int.Parse(Console.ReadLine()!);

if (day < 1)  Console.WriteLine("There is no such day in Gregorian calendar");
else if (day > 7)  Console.WriteLine("There is no such day in Gregorian calendar");
else if (day == 7) Console.WriteLine("Holiday");
else if (day == 6) Console.WriteLine("Holiday");
else Console.WriteLine("Work Day");
