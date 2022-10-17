// Задача 36. Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] ->0

Console.WriteLine();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// int[] array = {3, 7, 23, 12};
// int[] array = {-4, -6, 89, 6};
int[] array = FillArray(sizeArray);
PrintArray(array);

int sumNoEN = SumNoEvenNumbers(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна: {sumNoEN}");
Console.WriteLine();


int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : $"{arr[i]}]");
    Console.WriteLine();
}


int SumNoEvenNumbers(int[] arr)
{
    int sum = default;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}