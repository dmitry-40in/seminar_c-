// Задача 25. Напишите цикл, который принимает на вход
// два числа (А и В) и возводит число А в натуральную степень В.
// 3, 5 -> 243
// 2, 4 -> 16

Console.WriteLine();

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numberB > 0)
{
    int powerAB = MethodExponentB(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {powerAB}");
    Console.WriteLine();
}
else
{
    Console.WriteLine("Число В не натуральное число");
    Console.WriteLine();
}

int MethodExponentB(int baseA, int exponentB)
{
    int power = 1;
    for (int i = 1; i <= exponentB; i++) power = power * baseA;
    return power;
}

