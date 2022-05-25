// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
Console.WriteLine("Введите значения M и N: ");
int M = int.Parse(Console.ReadLine());
int N = int.Parse(Console.ReadLine());

int SumRec(int M, int N)
{
    if (M == N)
    {
        return N;
    }
    else return N + SumRec(M, N - 1);
}
Console.WriteLine(SumRec(M, N));