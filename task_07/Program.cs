

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <=999)
{
int lastDigit = number % 10;
Console.WriteLine($"Последняя цифра числа => {lastDigit}");
}
else
{
    Console.WriteLine("Число не трехзначное");
}