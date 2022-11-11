// Задача 58. Задайте две матрицы
// Напишите программу, которая будет находить произведение двух матриц
// Например, даны 2 матрицы
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int minRnd = -10;
int maxRnd = 10;

Console.WriteLine();
Console.Write("Введите количество строк первого двумерного массива: ");
int line1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов первого двумерного массива: ");
int column1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = FillMatrix(line1, column1, minRnd, maxRnd);

Console.WriteLine();
Console.Write("Введите количество строк второго двумерного массива: ");
int line2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов второго двумерного массива: ");
int column2 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = FillMatrix(line2, column2, minRnd, maxRnd);

Console.WriteLine();
Console.WriteLine("Первый массив:");
PrintMatrix(matrix1);
Console.WriteLine();
Console.WriteLine("Второй массив:");
PrintMatrix(matrix2);
Console.WriteLine();

if (CheckForMultiplication(matrix1, matrix2))
{
    int[,] resultOfMultiply2Matrix = Multiply2Matrix(matrix1, matrix2);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(resultOfMultiply2Matrix);
}
else Console.WriteLine("Заданные массивы перемножить нельзя");



int[,] Multiply2Matrix(int[,] array2D1, int[,] array2D2)
{
    int[,] resultOfMultiply = new int[array2D1.GetLength(0), array2D2.GetLength(1)];
    int sum = default;

    for (int m = 0; m < resultOfMultiply.GetLength(0); m++)
    {
        for (int k = 0; k < resultOfMultiply.GetLength(1); k++)
        {
            for (int i = 0; i < array2D1.GetLength(1); i++)
            {
                sum = sum + array2D1[m, i] * array2D2[i, k];
            }
            resultOfMultiply[m, k] = sum;
            sum = 0;
        }
    }
    return resultOfMultiply;
}


bool CheckForMultiplication(int[,] arr2D1, int[,] arr2D2)
{
    return arr2D1.GetLength(1) == arr2D2.GetLength(0);
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
    int[,] array2D = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array2D[i, j] = rnd.Next(min, max + 1);
        }
    }
    return array2D;
}