// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
//  34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число");
int digit1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int digit2 = Convert.ToInt32(Console.ReadLine());

int result = digit2 % digit1;

bool Even(int a)
{
    // if (a == 0) return true;
    // return false;
    return a == 0 ? true : false;
}  

bool A = Even(result);
Console.WriteLine(A);








// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int num = number1 % number2;

// if (num == 0)
// {
//     Console.WriteLine($"Первое число {number1} кратно второму {number2}");
// }
// else
// {
//     Console.WriteLine($"Остаток от деления {num}");
// }
