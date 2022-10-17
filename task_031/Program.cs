// Задача 31. Задайте массив из 12 элементов,
// заполниенный случвйными числами из промежутка [-9, 9]
// Найдите сумму отрицательных элементов массива

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random(); // var когда из правой части ясно какой объект используем 
    // var r = 5 + 10 / 3; если это еще и переменные - он сам определяет по умолчанию какое число - если навести и видно
    // что тип int или иной var r = r + f / g - тут нельзя var использовать - не понятно какой тип переменных

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1); // потому что первое число из генерации включено в генерацию а последнее
        // - нет,потэтому  чтобц включить   max + 1
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},  ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int[] GetSumPositiveNegativElem(int[] array)
{
    int sumNegative = default;
    int sumPositive = default;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sumNegative += array[i];
        else sumPositive += array[i];
    }

    // int[] resault = new int[2];
    // resault[0] = sumNegative;
    // resault[1] = sumPositive;
    int[] resault = { sumNegative, sumPositive};
return resault; // return new int[] {sumNegative; sumPositive}; - вернуть без дополнительной переменной
}

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int[] resault = GetSumPositiveNegativElem(arr);

Console.WriteLine($"Сумма положительных чисел = {resault[1]};, сумма отрицательных чисел = {resault[0]}");