// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
// Например, задан массив размером 2 х 2 х 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


Console.Write("Введите количество строк трехмерного массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов трехмерного массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите глубину трехмерного массива: ");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


Console.WriteLine("Список всех возможных двузначных чисел:");
int[] dictionary = MakeDictionaryOf2DigitsNumbers();
PrintArray(dictionary);
Console.WriteLine();


int[,,] array3D = new int[rows, columns, depth];


if (CheckRandom2Digit(array3D))
{
    array3D = FillArray3DRandom(rows, columns, depth, dictionary, array3D);
    Console.WriteLine("Результат: ");
    PrintArray3D(array3D);
    Console.WriteLine();
}
else Console.WriteLine("Такой массив нельзя заполнить неповторяющимися двузначными числами");




int[] MakeDictionaryOf2DigitsNumbers()
{
    int[] negativeNumbersDictionary = new int[90];
    int minNumber = -99;
    for (int i = 0; i < negativeNumbersDictionary.Length; i++)
    {
        negativeNumbersDictionary[i] = minNumber;
        minNumber = minNumber + 1;
    }

    int[] positiveNumbersDictionary = new int[90];
    int maxNumber = 99;
    for (int i = 0; i < positiveNumbersDictionary.Length; i++)
    {
        positiveNumbersDictionary[i] = maxNumber;
        maxNumber = maxNumber - 1;
    }

    int[] dictionary = new int[180];
    for (int i = 0; i < negativeNumbersDictionary.Length; i++)
    {
        dictionary[i] = negativeNumbersDictionary[i];
    }

    int j = 0;
    for (int i = negativeNumbersDictionary.Length; i < dictionary.Length; i++)
    {
        dictionary[i] = positiveNumbersDictionary[j];
        j = j + 1;
    }
    return dictionary;
}


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i],4}");
    }
    Console.WriteLine();
}


bool CheckRandom2Digit(int[,,] arr3D)
{
    return arr3D.Length <= 180;
}


int[,,] FillArray3DRandom(int line, int column, int depth, int[] dict, int[,,] arr3D)
{
    Random rnd = new Random();
    int index = default;

    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                index = rnd.Next(0, dict.Length);
                while (dict[index] == 100) // Можно взять любое недвузначное число. Использую чтобы случайные значения не повторялись.
                {
                    index = rnd.Next(0, dict.Length);
                }
                arr3D[i, j, k] = dict[index];
                dict[index] = 100;
            }
        }
    }
    return arr3D;
}


void PrintArray3D(int[,,] arr3D)
{
    for (int i = 0; i < arr3D.GetLength(0); i++)
    {
        for (int j = 0; j < arr3D.GetLength(1); j++)
        {
            for (int k = 0; k < arr3D.GetLength(2); k++)
            {
                Console.Write($"{arr3D[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}


