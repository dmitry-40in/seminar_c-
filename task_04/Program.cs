// Задача 4: Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine();
Console.WriteLine("Введите первое число: ");
int number_1 = Convert.ToInt32(Console.ReadLine()); // Выбрал тип int
Console.WriteLine("Введите второе число: ");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int number_3 = Convert.ToInt32(Console.ReadLine());

int max = number_1;

if (max < number_2)
{
    max = number_2;
}
if (max < number_3)
{
    max = number_3;
}

Console.WriteLine($"Максимальное число: <{max}>");