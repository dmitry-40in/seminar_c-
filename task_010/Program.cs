// Задача 10: Напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает втору цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine();
Console.WriteLine("Введите трехзначное число ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// if (x % 100 == 0 || x % 1000 != 0) // сделать условие если больше чем трехзначное
{
int number2 = (x / 10) % 10;

Console.WriteLine($"Вторая цифра числа {x}: {number2}");
Console.WriteLine();
}
else
{
    Console.WriteLine($"Введеное число {x} не трехзначное");
    Console.WriteLine();
}

