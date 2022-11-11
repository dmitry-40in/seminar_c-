// Задача 57. Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том сколько раз встречается эдемент входноыъ данных


// int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 2, 1, 6 } };
int[,] matrix = new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 5 } };


Console.WriteLine("Дана матрица");
PrintMatrix(matrix);
Console.WriteLine();


int arrayLength = matrix.GetLength(0) * matrix.GetLength(1);
int[] array = new int[arrayLength];


array = MakeArrayFromMatrix(matrix);
Console.WriteLine("Превартили матрицу в массив: ");
PrintArray(array);
Console.WriteLine();

array = SortArray(array);
Console.WriteLine("Сортируем массив: ");
PrintArray(array);
Console.WriteLine();

DictionaryArray(array);


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
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


int[] MakeArrayFromMatrix(int[,] matrix)
{
    int k = default;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k = k + 1;
        }
    }
    return array;
}



int[] SortArray(int[] arr)
{
    int tmp = default;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
        }
    }
    return arr;
}



void DictionaryArray(int[] arr)
{
    int counter = default;
    int number = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (number == arr[i])
        {
            counter = counter + 1;
        }
        else
        {
            Console.Write($"{arr[i - 1]} встречается {counter} раз");
            Console.WriteLine();
            counter = 1;
            number = arr[i];
        }
    }
   Console.WriteLine($"{number} встречается {counter} раз");
}