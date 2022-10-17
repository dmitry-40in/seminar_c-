// Задача 35 Задайте одномерный массив из 123 случайных чисел
// Найдите количество элементов массиваб значения котроых лежат в отрезке [10,99].

Console.Write("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
int summBi = default;


int[] array = FillArray(sizeArray);
summBi = FindSegment(array);
PrintArray(array);

Console.WriteLine();
Console.WriteLine($"Количество двухзначных элементтов в массиве равно: {summBi}");


int FindSegment(int[] arr)
{
    int sum = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] / 10 != 0 && arr[i] / 100 == 0) sum = sum + 1;
    }
    return sum;
}


int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(0, 255);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}]");
        }
    }
}