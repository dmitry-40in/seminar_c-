// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); //выбрал тип данных int

if (number % 2 == 0)
{
    Console.WriteLine("Это число чётное");
}
else
{
    Console.WriteLine("Это число не является чётным");
}
