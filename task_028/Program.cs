// Задача 28 Напишите программу которая
//принимает на вход число  N  и выдает
// произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


int multiNumber = MethodMulti(number);
Console.Write($"Произведение от 1 до {number}: ");
Console.WriteLine(multiNumber);


int MethodMulti(int num)
{
    int count = 1;
    int multi = 1;
    while (count <= number)
    {
        checked
        {
            multi = multi * count;
            count++;
        }
    }
    return multi;
}

