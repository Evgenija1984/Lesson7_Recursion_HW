// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array, int len)
{
    if(len == 0) return;

    Console.Write($"{array[len - 1]} ");
    PrintArray(array, len - 1);
}

int[] array = { 1, 2, 3, 4, 5};
int len = array.Length;
PrintArray(array, len);
