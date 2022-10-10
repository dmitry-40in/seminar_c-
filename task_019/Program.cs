// Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет; 23432 -> да; 12821 -> да


Console.WriteLine();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
if (number > 9999 && number < 100000) Console.WriteLine("Число пятизначное");
else Console.WriteLine("Число не пятизначное, но проверить на палиндромность можно");
Console.WriteLine();

string MethodPalindrome(int N)
{
    int invertedNumber = 0;
    int remainderOfDivision = 0;
    int n = N; //чтобы в методе сравнить перевернутое число с исходным (после цикла число N = 0)
    while (N != 0)
    {
        remainderOfDivision = N % 10;
        invertedNumber = invertedNumber * 10 + remainderOfDivision;
        N = N / 10;
    }
    return invertedNumber == n ? "Да" : "Нет";
}

Console.WriteLine($"{number} -> {MethodPalindrome(number)}");
Console.WriteLine();
