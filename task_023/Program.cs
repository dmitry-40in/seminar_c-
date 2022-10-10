// Задача 23. Напишите программу, которая принимает на вход 
// число (N) и выдает таблицн кубов чисел от 1 до N.
// 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());

void MethodCubeNumber(int number)
{
    for (int i = 1; i <= number; i++) Console.WriteLine($"{i,6} {Math.Pow(i, 3),6}");
}

Console.WriteLine();
Console.WriteLine($"Таблица кубов чисел от 1 до {N}");
MethodCubeNumber(N);
