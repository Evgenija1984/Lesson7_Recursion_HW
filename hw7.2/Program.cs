// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int FunctionAckermann(int m, int n)
{

    if(m == 0)
    {
        return n + 1;    
    } 
    if(m > 0 && n == 0) 
    {
        return FunctionAckermann(m - 1, 1);
    }
    if(m > 0 && n > 0) 
    {
       return FunctionAckermann(m - 1, FunctionAckermann(m, n - 1)); 
    }
    return FunctionAckermann(m, n);
}

int m = 3;
int n = 4;
Console.Write(FunctionAckermann(m, n));
