// Задача 26 Напишите программу которая
// принимает на вход число и выдает количество цифр в числе

// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Исползуем цикл while посколько не знаем сколько итераций будет

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int NumbersCount(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    } 
    return count;
}

int numbersCount = NumbersCount(number);
Console.Write($"Количество цифр в числе {number} -> {numbersCount}");