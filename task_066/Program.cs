// Задача 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от 
// M до N.
// M = 1; N = 15 -> 120;
// M = 4; N = 8 -> 30

Console.Write("Введите натуральное число M: ");
int numberM = EnterNaturalNumber();

Console.Write("Введите натуральное число N: ");
int numberN = EnterNaturalNumber();
Console.WriteLine();

int result = SumFromMToN(numberM, numberN);

Console.WriteLine($"M = {numberM}; N = {numberN} -> {result}");


int SumFromMToN(int numbM, int numbN)
{
    if (numbM > numbN) return numbM + SumFromMToN(numbM - 1, numbN);
    if (numbM < numbN) return numbN + SumFromMToN(numbM, numbN - 1);
    else  return numbM;
}


int EnterNaturalNumber()
{
    int numb = Convert.ToInt32(Console.ReadLine());
    while (numb < 1)
    {
        Console.Write("Введите натуральное число: ");
        numb = Convert.ToInt32(Console.ReadLine());
    }
    return numb;
}

