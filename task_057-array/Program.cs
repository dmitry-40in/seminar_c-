// Задача 57. Составить частотный словарь элементов двумерного массива
// Частотный словарь содержит информацию о том сколько раз встречается эдемент входноыъ данных


int[] array = new int[] {1, 9, 9, 0, 2, 8, 0, 9};

Console.WriteLine("Создан массив: ");
PrintArray(array);
Console.WriteLine();

SortArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine();

DictionaryArray(array);
Console.WriteLine();

void DictionaryArray(int[] arr)
{
    int counter = 1;

    for (int i = 0; i < arr.Length - 1; i++)
    {
        if (arr[i] == arr[i + 1])
        {
            counter = counter + 1;
        }
        else if (arr[i] == arr[i + 1] && )
        else
        {
            Console.Write($"{arr[i]} встречается {counter} раз");
            Console.WriteLine();
            counter = 1;
        }
    }

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


void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i], 4}");
    }
    Console.WriteLine();
}