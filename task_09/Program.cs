// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа. 
// 78 -> 8 12-> 2 85 -> 8

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапазона 10 - 99 => {number}");
int firstDigit = number / 10; // 78 / 10 = 7.8 , 8 отбрасывается при цулочисленном делении и получаем = 7
int secondfDigit = number % 10; // 78 % 10 = 8
if (firstDigit == secondfDigit) Console.WriteLine("Цифры одинаковые");
else if (firstDigit > secondfDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
else Console.WriteLine($"Наибольшая цифра числа = {secondfDigit}");


// добавить из семинара код с методом
// тернарный оператор ? :