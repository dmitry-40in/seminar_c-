// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N. 
// 5 -> 1, 4, 9, 16, 25. 2 -> 1,4

Console.WriteLine("Введите число N:");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Таблица квадратов чисел от 1 до {N}");
Console.WriteLine();
methodQuard(N);

void methodQuard(int number)
{
for (int i = 1; i <= number; i++) Console.WriteLine($"{i, 4} | {Math.Pow(i,2), 4}"); // \t - табуляция а мы в выводе поставили длину строки куда вписываем выводимое значение {x, длина строки для вывода}
}