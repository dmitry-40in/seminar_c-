// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между ними в 3М пространстве
// A(3, 6, 8); B(2, 1, -7) -> 15.84
// A(7, -5, 0); B(1, -1, 9) -> 11,53

Console.WriteLine();
Console.Write("Введите координату X точки А: ");
int dotAX = Convert.ToInt32(Console.ReadLine());        // Поскольку координаты в задании целочисленные поставил тип данных int
Console.Write("Введите координату Y точки А: ");
int dotAY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки А: ");
int dotAZ = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
Console.Write("Введите координату X точки В: ");
int dotBX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки В: ");
int dotBY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z точки В: ");
int dotBZ = Convert.ToInt32(Console.ReadLine());

double MethodLengthAB(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    double result = Math.Round(length, 2, MidpointRounding.ToZero);
    return result;
}

Console.WriteLine();
Console.WriteLine($"Рассточние между точками А и В равно {MethodLengthAB(dotAX, dotAY, dotAZ, dotBX, dotBY, dotBZ)}");
Console.WriteLine();
