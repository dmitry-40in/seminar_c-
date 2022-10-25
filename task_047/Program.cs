// Задача 47. Задайте двумерный массив размером m * n,
// заполненный случайными вещественными числами.
// m = 3, n = 4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк в двумерном массиве: m = ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: n = ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента двумерного массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента двумерного массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] matrix = FillMatrixRndDouble(linesMatrix, columnsMatrix, minMatrix, maxMatrix);

PrintMatrixDouble(matrix);
Console.WriteLine();


double[,] FillMatrixRndDouble(int lines, int columns, int min, int max)
{
    double[,] arr2D = new double[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1); // генерируем псевдо случайное и округляем вещественное число до десятых
        }
    }

    return arr2D;
}


void PrintMatrixDouble(double[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(j < arr2D.GetLength(1) - 1 ? $"{arr2D[i, j],5}," : $"{arr2D[i, j],5}");
        }
        Console.WriteLine("]");
    }
}