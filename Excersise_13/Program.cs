// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void PrintArray(int[] col)
// {
//     for (int i = 0; i < col.Length; i++)
//     Console.Write(col[i] + "  ");
// }

void NumberToArray(int number, int[] array)
{
    while (number > 0)
    {
        int digit = number % 10;
        array[number.ToString().Length - 1] = digit;
        number /= 10;
        // Математический путь (парсим число в массив не с конца, а с начала)
        // for (int i = 0; i < d; i++)
        // {
        //     array[i] = a / Convert.ToInt32(Math.Pow(10, d - i - 1)) - a / Convert.ToInt32(Math.Pow(10, d - i)) * 10;
        // }
        
    }
    // Console.Write("Number parsed to array: ");
    // PrintArray(array);  
}

Console.WriteLine("Enter number");
int a = int.Parse(Console.ReadLine()!);

if ( a < 100 )
    Console.WriteLine("There is no 3rs digit in this number");

else
{
    int[] array = new int[a.ToString().Length];
    NumberToArray(a, array);

    Console.WriteLine("The 3rd digit is: " + array[3-1]);
    // Console.WriteLine("What digit do you want to find?");
    // int digit = int.Parse(Console.ReadLine()!);
    // Console.WriteLine("This digin number is: " + array[digit-1]);
}