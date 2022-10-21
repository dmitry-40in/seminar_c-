// Задача 43. Напишите программу, которая найдет точку
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

Console.Write("Введите значение b1: ");
double numB1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double numK1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double numB2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double numK2 = Convert.ToDouble(Console.ReadLine());

double numX = FindX(numB1, numK1, numB2, numK2);
double numY = FindY(numX, numK1, numB1);

Console.WriteLine();
Console.WriteLine($"b1 = {numB1}, k1 = {numK1}, b2 = {numB2}, k2 = {numK2} -> ({numX}; {numY})");


double FindX(double b1, double k1, double b2, double k2)
{
    double x = Math.Round((b2 - b1) / (k1 - k2), 1);
    return x;
}

double FindY(double x, double k1, double b1)
{
    double y = Math.Round(k1 * x + b1, 1);
    return y;
}


