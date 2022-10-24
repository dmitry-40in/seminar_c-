// Задача 48 Задайте двумерный массив размера m на n каждый элемент в массиве находится по формуле
// Amn = m + n 
// Выведите полученный массив на экран
// m = 3 n =4
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("Введите количество строк m = ");
int lines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n = ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(lines, columns);

PrintMatrix(matrix);


int[,] FillMatrix( int linesMatrix, int columnsMatrix)
{
    int[,] matrix = new int[linesMatrix, columnsMatrix];
    for (int i = 0; i < linesMatrix; i++)
    {
        for (int j = 0; j < columnsMatrix; j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}


void PrintMatrix(int[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
           Console.Write(j < arr2D.GetLength(1) - 1 ? $"{arr2D[i, j]}, " : $"{arr2D[i, j]}]");
           //  (j < arr2D.GetLength(1) - 1) ? Console.Write($"{arr2D[i, j]}, ") : Console.Write($"{arr2D[i, j]}"); - почему то не работает
        }
        Console.WriteLine("]");
    }
}