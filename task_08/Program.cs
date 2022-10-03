// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); // выбрал тип данных int

int index = 2;

if (number >= index)
{
    
    Console.WriteLine();
    Console.WriteLine("Все чётные числа от 1 до N: ");
    while (index <= number)
    {
        Console.Write($"{index} ");
        index = index + 2;
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine();
    Console.WriteLine("Чётных чисел от 1 до N не существует");
    Console.WriteLine();
}