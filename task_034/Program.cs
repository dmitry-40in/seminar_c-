// Задача 34. Задайте массив заполненный случайными
// положительными трехзначными числами. Напишите
// программу, которая покажет количество четных чисел в массиве
// [345, 897, 568, 234] -> 2


Console.WriteLine();
Console.Write("Ввeдите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = FillArray(sizeArray);
PrintArray(array);
int sEN = SumEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве: {sEN}");
Console.WriteLine();


int[] FillArray(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}


int SumEvenNumbers(int[] arr)
{
    int sumEvenNumbers = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) sumEvenNumbers = sumEvenNumbers + 1;
    }
    return sumEvenNumbers;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : $"{arr[i]}]");
    Console.WriteLine();
}