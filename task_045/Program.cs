// Задача 45 - Напишите программу которая будет создавать
// копию заданного массива с помощью поэлементного копирования

int[] array1 = {1, 2, 44, 4, 5, 6, 7};


int[] newArray = new int[array1.Length];

for (int i = 0; i < array1.Length; i++)
{
    newArray[i] = array1[i];
    Console.Write($"{newArray[i]} ");
}




