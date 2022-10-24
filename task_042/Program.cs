// Задача 42 Напишите программу которая будет преобразовывать десятичное число в двоичное
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Binary(number));

int Binary(int num)
{
    int resault = 0;
    int count = 1;
    // string tmpString = default;
    while (num > 0)
    {
        resault = resault + num % 2 * count;
        num = num / 2;
        count = count * 10;
    }
    return resault;
}

