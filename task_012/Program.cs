// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//  34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

int num = number1 % number2;

if (num == 0)
{
    Console.WriteLine($"Первое число {number1} кратно второму {number2}");
}
else
{
    Console.WriteLine($"Остаток от деления {num}");
}
