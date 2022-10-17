// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве. 
// 4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальное значение элемента  массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число для поиска в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());

// int[] array = new int [size];
int[] array = FillArrayRnd(size, min, max);
Console.WriteLine();
Console.Write("Сгенерирован массив:");
PrintArray(array);

if (FindNumInArr(array, number)) Console.WriteLine($"Число {number} есть в массиве"); //  можно не писать == true тк bool
else Console.WriteLine($"Числа {number} нет в массиве");

Console.WriteLine(FindNumInArr(array, number) ? "Да" : "Нет"); // так тернарный оператор работает

// FindNumInArr(array, number) ? Console.WriteLine("y") : Console.WriteLine("n"); - так тренарный оператор не работает



bool FindNumInArr(int[] arr, int num)
{
    //bool resault = default;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
            // break;
        }
        //else return false;           // попробовать избавиться от переменной resault
    }
    return false;
    //return resault;
}


void PrintArray(int[] arr)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.WriteLine($"{arr[i]}]");
    }
}


int[] FillArrayRnd(int sizeA, int minA, int maxA)
{
    int[] arr = new int[sizeA];
    Random rnd = new Random();
    for (int i = 0; i < sizeA; i++)
    {
        arr[i] = rnd.Next(minA, maxA + 1);
    }
    return arr;
}