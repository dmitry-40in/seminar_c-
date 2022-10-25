// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//1 4 7 2
//5 9 2 3 
//8 4 2 4
// 1,7 -> такого элемента в массиве нет

// Массив решил заполнять случайными вещественными числами

Console.Write("Введите количество строк в двумерном массиве: ");
int linesMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введеите количество столбцов в двумерном массиве: ");
int columnsMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента массива: ");
int minMatrix = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное хначение элемента массива: ");
int maxMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] matrix = FillMatrixRnd(linesMatrix, columnsMatrix, minMatrix, maxMatrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.Write("Введите номер строки искомого элемента двумерного массива: ");
int lineFindElement = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца искомого элемента двумерного массива: ");
int columnFindElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int indexXFindElement = lineFindElement - 1;
int indexYFindElement = columnFindElement - 1;

Console.WriteLine(FindElementMatrix(indexXFindElement, indexYFindElement, matrix) ? 
$"{lineFindElement}, {columnFindElement} -> {matrix[indexXFindElement, indexYFindElement]}" : 
$"{lineFindElement}, {columnFindElement} -> такого элемента в массиве нет");



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


bool FindElementMatrix(int indexI, int indexJ, int[,] array2D)
{
    return indexI >= 0 && indexI < array2D.GetLength(0) && indexJ >= 0 && indexJ < array2D.GetLength(1) ? true : false;
}