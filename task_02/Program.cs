// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine();
Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine()); // тип числа выбираю  int
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2)
{
    Console.WriteLine();
    Console.WriteLine("Числа равны");
}
else
{
    if (number_1 > number_2)
    {
        Console.WriteLine();
        Console.WriteLine($"Первое число <{number_1}> - больше");
        Console.WriteLine($"Второе число <{number_2}> - меньше");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Первое число <{number_1}> - меньше");
        Console.WriteLine($"Второе число <{number_2}> - больше");
    }
}





