// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine();
Console.Write("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите минимальное значение для генерации случайного элемента массива: ");
int minArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите максимальное значение для генерации случайного элемента массива: ");
int maxArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// double[] array = {3.5, 7.1, 22.9, 2.3, 78.5};
double[] array = FillArray(sizeArray, minArray, maxArray);
PrintArray(array);

double maxNumberArray = MaxArrayNumber(array);
double minNumberArray = MinArrayNumber(array);

double result = maxNumberArray - minNumberArray;
Console.WriteLine($"Разница между максимальныи и минимальным элементами массива равна: {result}");


double MaxArrayNumber(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

double MinArrayNumber(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}


double[] FillArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double rndNum = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(rndNum, 2);
    }
    return arr;
}


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++) Console.Write(i < arr.Length - 1 ? $"{arr[i]}, " : $"{arr[i]}]");
    Console.WriteLine();
}