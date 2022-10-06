// Задача 10: Напишите программу, которая принимает на вход трехзначное число и 
// на выходе показывает втору цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine();
Console.WriteLine("Введите трехзначное число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// if (Math.Abs(x) >= 100 && Math.Abs(x) <= 999)
// {
//     int number2 = Math.Abs((x / 10) % 10);

//     Console.WriteLine($"Вторая цифра числа {x}: {number2}");
//     Console.WriteLine();
// }
// else
// {
//     Console.WriteLine($"Введеное число {x} не трехзначное");
//     Console.WriteLine();
// }

bool Method3digitABS(int num)   // Создал возвратный метод на проверку трехзначности и использования отрицательных чисел
{
return Math.Abs(num) >= 100 && Math.Abs(num) <= 999;
}

int MethodSecondDigit(int numberP)
{
    return Math.Abs((numberP / 10) % 10);   // Создал возвратный метод выделение 2-ой цифры, и в отрицательных числах
}

if (Method3digitABS(x)) Console.WriteLine($"Вторая цифра числа {x}: {MethodSecondDigit(x)}");
else Console.WriteLine($"Введеное число {x} не трехзначное");
