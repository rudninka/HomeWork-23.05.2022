// Задача 68: Напишите программу вычисления функции Аккермана с помощью
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29
int Ak(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    else if (m > 0 && n == 0)
    {
        return Ak(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return Ak(m - 1, Ak(m, n - 1));
    }
    return 0;
}
Console.WriteLine(Ak(3, 2));
