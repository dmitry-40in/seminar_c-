// Задача 44 - Не используя рекурсию выведите первые N чисел Фибоначчи
// Первые два числа Фибоначи 0 и 1

int n1 = 1;
int n2 = 2;
int n3 = default;

int size = 7;

void Fibonacci(int num)
{
    int firstN = 0;
    int secondN = 1;
    Console.Write($"{firstN} {secondN}");
    for (int i = 0; i < num - 2; i++)
    {
        int nextN = firstN + secondN;
        Console.Write($"{nextN}");
        firstN = secondN;
        secondN = nextN;
    }
}

Fibonacci(size);
