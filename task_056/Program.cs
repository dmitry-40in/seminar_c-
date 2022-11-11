// Задача 56. Задайте двумерный массив
// Напишите программу, которая будет находить строку с наименьшей суммой элементов
// Например, задан массив
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдает номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Введите количество строк двумерного массива: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов двумерного массива: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int minRnd = -10;
int maxRnd = 10;

Console.WriteLine("Двумерный массив для нахождения номера строки с наименьшей суммой элементов:");
int[,] matrix = FillMatrix(line, column, minRnd, maxRnd);
PrintMatrix(matrix);
Console.WriteLine();

int[] arrayOfSum = ArrayOfSumNumFromRowsMatrix(matrix);

PrintNumberOfMinSumRow(arrayOfSum);


void PrintNumberOfMinSumRow(int[] arr)
{
    int MinSumRow = arr[0];
    int indexMinSumRow = default;
    for (int i = 1; i < arr.Length; i++)
    {
        if (MinSumRow > arr[i])
        {
            MinSumRow = arr[i];
            indexMinSumRow = i;
        }
    }
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {indexMinSumRow + 1} строка");
    Console.WriteLine();
}


int[] ArrayOfSumNumFromRowsMatrix(int[,] arr2D)
{
    int[] array = new int[arr2D.GetLength(0)];
    int sum = default;

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            sum = sum + arr2D[i, j];
        }
        array[i] = sum;
        sum = 0;
    }
    return array;
}


void PrintMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            Console.Write($"{arr2D[i, j],4}");
        }
        Console.WriteLine();
    }
}


int[,] FillMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}