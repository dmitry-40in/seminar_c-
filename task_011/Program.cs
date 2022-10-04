// Задача 11. Напишите программу, которая выводит 
// случайное трёхзначное число и удаляет вторую цифру этого числа. 
// 456 -> 46 782 -> 72 918 -> 98

// int number = new Random().Next(100,1000);
// Console.WriteLine($"Случайное число: {number}");
// int firstDigit = number / 100;
// int thirdDigit = number % 10;
// int number2 = firstDigit * 10 + thirdDigit;
// Console.WriteLine($"Результат: {number2}");

// Решение через методом

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число: {number}");
int NumberPrint(int num)
{
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    return firstDigit * 10 + thirdDigit;
}
int result = NumberPrint (number); // Рекомендуют выводить результат в отдельную переменную и ее в результате
Console.WriteLine($"{number} -> {result}");