// Задача 41: пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввел пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

Console.WriteLine();
Console.Write("Сколько чисел будите вводить: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = new int[number];
array = FillArray(array);

int numbers = NumbersGreaterThanZero(array);

PrintArray(array);
Console.WriteLine($" -> {numbers}");


int[] FillArray(int[] arr)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}


void PrintArray(int[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++) Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : $"{arr[i]}");
}


int NumbersGreaterThanZero(int[] arr)
{
    int count = default;
    for (int i = 0; i < arr.Length; i++) count = arr[i] > 0 ? count + 1 : count;
    return count;
}