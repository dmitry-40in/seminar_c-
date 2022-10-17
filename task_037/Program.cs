// Задача 37 Найдите произведение пар чисел в одномерном массиве
// Парой считается первый и последний элемент
// второй и предпоследний и тд
// Результат запишите в новом массиве
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] array = { 1, 2, 3, 4, 5 };
int[] array = { 6, 7, 3, 6 };

PrintArray(array);
Console.WriteLine();

if (array.Length % 2 == 0)
{
    int[] newArray = new int[array.Length / 2];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    PrintArray(newArray);
}
else
{
    int[] newArray = new int[array.Length / 2 + 1];
    for (int i = 0; i < newArray.Length - 1; i++)
    {
        newArray[i] = array[i] * array[array.Length - 1 - i];
    }
    newArray[newArray.Length - 1] = array[array.Length / 2];
    PrintArray(newArray);
}







void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i < array.Length - 1 ? $"{array[i]}, " : $"{array[i]}]");
    }
}
