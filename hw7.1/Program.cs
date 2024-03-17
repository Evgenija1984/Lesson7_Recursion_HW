// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

void PrintNumbers(int m, int n)
{
    if (m > n) return;
    Console.Write($"{m} ");
    PrintNumbers(m + 1, n);
}

int m = 1;
int n = 5;
PrintNumbers(m, n);
