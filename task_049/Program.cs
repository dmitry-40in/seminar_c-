// Задача 49 - задайте двумерный массив.
// Найдите элементы у которых оба индекса четные и замените эти элементы на их квадраты

Console.Write("Введите количество строк матрицы: ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов матрицы: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента матрицы: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента матрицы: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());



int[,] matrix = FillMatrixRnd(linesMatrix, columnsMatrix, minMatrix, maxMatrix);
PrintMatrix(matrix);
Console.WriteLine();
FillMatrixSquare(matrix);
PrintMatrix(matrix);




int[,] FillMatrixRnd(int lines, int columns, int min, int max)
{
    int[,] arr2D = new int[lines, columns];
    Random rnd = new Random();

    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr2D[i, j] = rnd.Next(min, max);
        }
    }
    return arr2D;
}


void PrintMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write(j < arr2D.GetLength(1) - 1 ? $"{arr2D[i, j], 4}, " : $"{arr2D[i, j], 4}]");
        }
        Console.WriteLine();
    }
}


int[,] FillMatrixSquare(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < arr2D.GetLength(1); j = j + 2)
        {
            arr2D[i, j] = Convert.ToInt32(Math.Pow(arr2D[i, j], 2));
        }
    }
    return arr2D;
}

