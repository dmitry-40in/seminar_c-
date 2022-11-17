// повторение и разбор заново

// int num = 10;

// PrintRekursia(num);

// void PrintRekursia(int a)
// {
//     //  выводит значения 10 9 8 7 6 5 4 3 2 1 0 (если условие а == 0)
//     // Console.WriteLine(a);
//     if (a == 0)
//     {
//         // выводит а при выполнении условия (сейчас это а == 0)
//         // Console.WriteLine(a);
//         return;
//     }
//     else
//     {
//         //  выводит значения 10 9 8 7 6 5 4 3 2 1 (если условие а == 0, 0 не выводит)
//         // Console.WriteLine(a);
//         PrintRekursia(a - 1);
//         Console.WriteLine(a);
//         //  выводит значения 1 2 3 4 5 6 7 8 9 10
//     }
// }


int[] array = new int[] {1, 2, 3, 4, 5};
int number = 5;
int i0 = 0;
int iEnd = array.Length - 1; 

// SearchArrayIter(array, number);

// void SearchArrayIter(int[] arr, int numb)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == numb) Console.WriteLine($"Элемент найден под индексом {i},  номер элемента {i + 1}");
//     }
// }


if 

int result SearchArrayRecursion(int[] arr, int numb, int begin, int end)
{
    SearchArrayRecursion(arr, numb, begin + 1, end);
    return result;
}
