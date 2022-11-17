// Задача 67. Напишите программу, которая будет принимать на вход число
// и возвращает сумму его цифр
// 453 -> 12

int number = 453;



int s = Method(number);
Console.Write(s);
Console.WriteLine();

int ss = Method2(number);
Console.Write(ss);

int Method(int num)
{
    if (num == 0) return 0;
    return num % 10 + Method(num / 10);
}

int Method2(int num)
{
    int s = 0;
    if (num == 0) return 0;
        Method(num / 10);
    return  s = s + num % 10; 
}