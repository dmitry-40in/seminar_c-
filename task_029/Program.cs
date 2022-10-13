// Задача 29. Напишите программу, которая задает массив из 8 элементов
// заполненный псевдослучайными числами и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
// int[] array = {1, 2, 5, 7, 19, 6, 1, 33};

MethodFillArray(array);
MethodPrintArray(array);


void MethodFillArray(int[] arr)
{
    Random rnd = new Random();
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(0, 100);
    }
}


void MethodPrintArray(int[] arr)
{
    Console.WriteLine();
    int length = arr.Length;
    Console.Write($"[{arr[0]}, ");
    for (int i = 1; i < length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[length - 1]}]");
    Console.WriteLine();
    Console.WriteLine();
}
