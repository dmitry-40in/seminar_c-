// Задча 40 Напишите программу которая принимает на вход 
// три числа и проверяет может ли существовать 
// треугольник со сторонами такой длины
// теорема о неравенстве треуголника - каждая сторона треуголника меньше суммы двух других сторон

Console.Write("Введите длину первой стороны: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину второй стороны: ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину третьей стороны: ");
int numberC = Convert.ToInt32(Console.ReadLine());

bool Triangle(int a, int b, int c)
{
    return (a < b + c && b < a + c && c < a + b);
}

Console.WriteLine(Triangle(numberA, numberB, numberC) ? "Такой треуголник может существовать" : "Такой треугольник не может существовать");

