// Задача 39 Напишите программу которая преведрнет одномерный массив 
// Последний элемент будет на первом месте а первый на послденем
// 1 2 3 4 5 -> 5 4 3 2 1

int[] arr = {1, 2, 3, 4, 5};

// Array.Reverse(arr);

ReverseArray(arr);

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}



PrintArray(arr);

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i < array.Length - 1 ? $"{array[i]}, " : $"{array[i]}]");
    }
}