// Задача 53. Задайте двумерный массив
// Напишите программу которая поменяет местами первую и последнюю строку массива

Console.Write("Введите количество строк в двумероном массиве: ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в двумерном массиве: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

int minRndMatrix = -10;
int maxRndMatrix = 10;


int[,] matrix = FillMatrix(linesMatrix, columnsMatrix, minRndMatrix, maxRndMatrix);
PrintMatrix(matrix);

Console.WriteLine();

int[,] replacedMatrix = ReplaceMatrix(matrix);
PrintMatrix(replacedMatrix);



int[,] FillMatrix(int lines, int columns, int min, int max)
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


int[,] ReplaceMatrix(int[,] arr2D)
{
    int tmp = default;
    int lastLineMatrix = arr2D.GetLength(0) - 1;

    int i = 0;

    for (int j = 0; j < arr2D.GetLength(1); j++)
    {
        tmp = arr2D[i, j];
        arr2D[i, j] = arr2D[lastLineMatrix, j];
        arr2D[lastLineMatrix, j] = tmp;
    }
    return arr2D;
}