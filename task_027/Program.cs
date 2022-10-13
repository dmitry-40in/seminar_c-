// Задача 27. Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberAbs = Math.Abs(number); // Чтобы можно было сосчитать сумму цифр отрицательного числа
                                  // рассчеты провожу с модулем введенного числа
Console.WriteLine();

int numberFromSummDigits = MethodSummDigits(numberAbs);
Console.WriteLine($"{number} -> {numberFromSummDigits}");
Console.WriteLine();


int MethodSummDigits(int num)
{
    int summDigits = default;
    for (int i = 1; num != 0; i++)
    {
        summDigits = summDigits + num % 10;
        num = num / 10;
    }
    return summDigits;
}