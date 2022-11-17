// Задача 68. Напишите программу вычисления функции Аккермана с помощью рекурсии
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m: ");
int numberM = EnterNaturalNumberAnd0();
Console.Write("Введите число n: ");
int numberN = EnterNaturalNumberAnd0();

int result = AkkermanFunction(numberM, numberN);
Console.WriteLine($"Значение функции Аккермана равно: {result}");



int AkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}


int EnterNaturalNumberAnd0()
{
    int numb = Convert.ToInt32(Console.ReadLine());
    while (numb < 0)
    {
        Console.Write("Введите натуральное число: ");
        numb = Convert.ToInt32(Console.ReadLine());
    }
    return numb;
}
