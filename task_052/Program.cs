// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine();
Console.Write("Введите количество строк в двумерном массиве: ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] matrix = FillMatrixRnd(linesMatrix, columnsMatrix, minMatrix, maxMatrix);
double[] average = AverageOfColumnsMatrix(matrix);

PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(average);
Console.WriteLine();


int[,] FillMatrixRnd(int lines, int columns, int min, int max)
{
    int[,] arr2D = new int[lines, columns];
    Random rnd = new Random();
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return arr2D;
}


double[] AverageOfColumnsMatrix(int[,] arr2D)
{
    double[] array = new double[arr2D.GetLength(1)];

    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        int summElementsColumns = default;

        for (int i = 0; i < arr2D.GetLength(0); i++)
        {
            summElementsColumns = summElementsColumns + arr2D[i, j];
        }
        array[j] = Math.Round(((double)summElementsColumns / arr2D.GetLength(0)), 1); // чтобы получить рещультат типа double 
        // привел одно из значений для вычисления в double, инче  int / int = int
        // также округлил результат до десятичных
    }
    return array;
}


void PrintMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j],5}");
        }
        Console.WriteLine();
    }
}


void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(i < arr.Length - 1 ? $"{arr[i],1}; " : $"{arr[i],1}.");
    }
}