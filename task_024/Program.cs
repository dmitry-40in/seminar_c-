// Задача 24 Напишите программу которая 
// 1 принимает на вход число (А) и
// 2 выдает сумму чисел от 1 до А

// 7 - 28
// 4 - 10
// 8 - 36

Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SummNumbers(number); // Лучше результат метода выводить в переменную для читаемости и отладки
Console.WriteLine(sumNumbers);

int SummNumbers(int num)
{
    int sum = default; // значение для переменно будет определено в дальнейшем, чтобы понимать что это число не учитывается в работе цикла
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i;
    }
    return sum;
}