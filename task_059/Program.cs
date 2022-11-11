// Задача 59. Задайте дваумерный массив из целых чисел
// Напишите программу которая удалит строку и столбец на пересечении
// которых распооложен наименьший элемент массива

int[,] matrix = new int[,] { { 8, 4, 7, 8 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 }, { 5, 2, 6, 7 } };
Console.WriteLine("Задали массив");
PrintMatrix(matrix);
Console.WriteLine();


int[] indexMin = IndexToDelete(matrix);
PrintArray(indexMin);
Console.WriteLine();


int[,] newMatrix = MakeMatrixWithoutMin(matrix, indexMin);
PrintMatrix(newMatrix);
Console.WriteLine();


int[,] newMatrix2 = AnotherMethodNewMatrix(matrix, indexMin);
PrintMatrix(newMatrix2);
Console.WriteLine();




int[,] MakeMatrixWithoutMin(int[,] arr2D, int[] indexMinNumber)
{
    int[,] matrixWithoutMin = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];

    int k = indexMinNumber[0];
    int l = indexMinNumber[1];

    for (int i = 0; i < matrixWithoutMin.GetLength(0); i++)
    {
        for (int j = 0; j < matrixWithoutMin.GetLength(1); j++)
        {
            if (i < k)
            {
                if (j < l)
                {
                    matrixWithoutMin[i, j] = arr2D[i, j];
                }
                else // j >= l
                {
                    matrixWithoutMin[i, j] = arr2D[i, j + 1];
                }
            }
            else // i >= k
            {
                if (j < l)
                {
                    matrixWithoutMin[i, j] = arr2D[i + 1, j];
                }
                else // j >= l
                {
                    matrixWithoutMin[i, j] = arr2D[i + 1, j + 1];
                }
            }
        }
    }
    return matrixWithoutMin;
}



int[,] AnotherMethodNewMatrix(int[,] arr2D, int[] array)
{
    int[,] newMatrix = new int[arr2D.GetLength(0) - 1, arr2D.GetLength(1) - 1];

    int k = 0;
    int l = 0;

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        if (k == array[0]) k++;
        for (int j = 0; j < newMatrix.GetLength(1); j++)     
        {
            if (j == array[1]) l++;
            newMatrix[i, j] = arr2D[k, l];
            l++;
        }
        l = 0;
        k++;
    }

    return newMatrix;
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


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i],4}");
    }
    Console.WriteLine();
}

int[] IndexToDelete(int[,] matrix)
{
    int min = matrix[0, 0];
    int[] indexMin = new int[2];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMin[0] = i;
                indexMin[1] = j;
            }
        }
    }
    return indexMin;
}