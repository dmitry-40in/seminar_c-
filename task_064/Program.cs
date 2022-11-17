// Задача 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N
// до 1. Выполнить с помощью рекурсии
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


int number = EnterNaturalNumber();
Console.WriteLine();

Console.Write($"N = {number} -> \"");
ShowFromNTo1Recursion(number);
Console.WriteLine();


void ShowFromNTo1Recursion(int numb)
{
    if (numb == 0) return;
    if (numb != 1)
    {
    Console.Write($"{numb}, ");
    ShowFromNTo1Recursion(numb - 1);
    }
    else Console.WriteLine($"{numb}\"");
}


int EnterNaturalNumber()
{
    Console.Write("Введите натуральное число N: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    while (numb < 1)
    {
        Console.Write("Введите натуральное число N: ");
        numb = Convert.ToInt32(Console.ReadLine());
    }
    return numb;
}
