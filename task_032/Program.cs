// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот. 
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

Console.Write("Введите количество элементов в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(number);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
InverseArray(array);
Console.WriteLine();
PrintArray(array);



void InverseArray(int[] arr)
{
    for (int z = 0; z < arr.Length; z++)
    {
        arr[z] = arr[z] * -1;
    }
}


int[] FillArray(int numberOfElements)
{
    int[] array = new int[numberOfElements];
    Random rnd = new Random();
    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    return array;
}


void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}]"); // хочу тернарным оператором
    }
}
