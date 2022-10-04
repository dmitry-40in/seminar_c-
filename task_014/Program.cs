// Задача 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23. 
// 14 -> нет 46 -> нет 161 -> да

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int num = number % 7;
int num2 = number % 23;

if (num == 0 && num2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
