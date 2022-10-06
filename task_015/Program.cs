// Задача 15. Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.WriteLine();
Console.WriteLine("Введите цифру");
int digit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (digit % 10 != 0 || digit == 0) // Проверка на цифру, 0 тоже цифра
{
    if (digit == 6 || digit == 7) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Введите цифру");
