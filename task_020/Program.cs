// Задача 20: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве. 
// A (3,6); B (2,1) -> 5,09 A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координату X1");
double x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y1");
double y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату X2");
double x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату Y2");
double y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(methodLength(x1, y1, x2, y2));

double methodLength(double xc1, double yc1, double xc2, double yc2)
{
double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
double dist = Math.Round(length, 2, MidpointRounding.ToZero);
return dist;
}


//  для читаемости когда лучше ввести переменные на выражения и