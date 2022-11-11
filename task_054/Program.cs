// Задача 54. Задайте двумерный массив
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива
// Например, задан массив
// 1 4 7 2
// 5 9 2 3 
// 8 4 2 4
// В итоге получается вот такой массив
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Введите количество строк в двумерном массиве:");
int line = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве:");
int column = Convert.ToInt32(Console.ReadLine());

int minNumRnd = -10;
int maxNumRnd = 10;

Console.WriteLine();
Console.WriteLine("Двумерный массив для сортировки создан: ");
int[,] matrixForSort = FillMatrix(line, column, minNumRnd, maxNumRnd);
PrintMatrix(matrixForSort);
Console.WriteLine();

Console.WriteLine("Отсортированный двумерный массив:");
int[,] sortedMatrix = SortMatrix(matrixForSort);
PrintMatrix(sortedMatrix);


int[,] SortMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1) - 1; j++)
        {
            int tmp = default;

            for (int k = j + 1; k < arr2D.GetLength(1); k++)
            {
                if (arr2D[i, j] < arr2D[i, k])
                {
                    tmp = arr2D[i, j];
                    arr2D[i, j] = arr2D[i, k];
                    arr2D[i, k] = tmp;
                }
            }
        }
    }
    return arr2D;
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