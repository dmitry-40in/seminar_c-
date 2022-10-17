// Задача 30 - напишите программу которая выводит
// массив из 8 элементов заполненный нулями и единицами в случайном порядке 
// [1, 0, 1, 1, 0, 1, 0, 0] 12






// РАЗОБРАТЬ ЭТУ ЗАДАЧУ САМОМУ И ПО СЕМИНАРУ + ОБЪЯСНЕНИЯ ПО ГЕНЕРАЦИИ ЧИСЕЛ Т
// В ЦИКЛЕ НЕ УСПЕВАЕТ СГЕНЕРИВРОВАТЬ РАЗНЫЕ ПОЭТО
// ВНЕ ЦИКЛА ГЕНЕРИРУЕМ ОБЪЕКТ В Ы ЦИКЛЕ РАБОТАЕМ

int[] array = new int[8];

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++) // не нужно тут числа а нужно переменные  не i < 8 а i < array.Length и тогда надо возвращать метод
    {
        arr[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}

FillArray(array);
PrintArray(array);

