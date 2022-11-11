// Задача 55. Задайте двумерный массив
// Напишите программу которая заменяет строки на столбцы
// В случае если это невозможно программа должная вывести сообщение для пользователя

Console.Write("Ввeдите количество строк в двумерном массиве: ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количетво столбцов в двумерном массиве: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

int min = -10;
int max = 10;

int[,] matrix = FillMatrix(linesMatrix, columnsMatrix, min, max);
PrintMatrix(matrix);

Console.WriteLine();

if (SquareMatrix(matrix))
{
    Console.WriteLine("Матрица квадратная");
    Console.WriteLine();
    int[,] replacedMatrix = ReplaceMatrix(matrix);
    PrintMatrix(replacedMatrix);
}
else
{
    Console.WriteLine("Матрица не квадратная. Заменить строки на столбцы не получится");
}




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

bool SquareMatrix(int[,] arr2D)
{
    return arr2D.GetLength(0) == arr2D.GetLength(1);
}


int[,] ReplaceMatrix(int[,] arr2D)
{
    int tmp = default;

    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = i; j < arr2D.GetLength(1); j++)
        {
            tmp = arr2D[i, j];
            arr2D[i, j] = arr2D[j, i];
            arr2D[j,i] = tmp;
        }
    }
    return arr2D;
}