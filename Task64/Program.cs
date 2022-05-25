//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 6, 7, 8"
Console.WriteLine("Введите значения M и N: ");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

void Rec(int M, int N)
{
    if (M > N)
    {
        return;
    }
    Console.Write(M + " ");
    Rec(M + 1, N);
}
Rec(M, N);
{
    if (N > M)
    {
        return;
    }
    Console.Write(N + " ");
    Rec(N + 1, M);
}
