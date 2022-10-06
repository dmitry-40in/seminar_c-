// Задача 13. Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет 
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine();
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

// Нахожу кол-во разрядов (по счетчику countDigit)
int countDigit = 1;
int numberForCountDigit = number;
while (numberForCountDigit / 10 != 0)
{
    numberForCountDigit = numberForCountDigit / 10;
    countDigit++;
}

// Перевожу кол-во разрядов в число (digitForDel) необходимое для выделения нового числа,
// начинающегося с третьей цифры введенного числа
int digitForDel = 1;
for (int i = 1; i <= countDigit - 2; i++) digitForDel = digitForDel * 10;

// если введеное число 3-х значное, то создаю из введенного числа новое с первой искомой цифрой и выделяю эту цифру
// если не 3-х значное, то вывод по условию
int result = 0;
if (countDigit >= 3)
{
    result = number % digitForDel / (digitForDel / 10);
    Console.WriteLine($"Третья цифра слева: {result}");
}
else Console.WriteLine("Третьей цифры нет");

