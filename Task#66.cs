// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Write("Введите первое число: ");
int n66 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int m66 = int.Parse(Console.ReadLine());

static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N+1)/2);
    else if (N == 0) return (M * (M+1)/2);
    else if (M == N) return M;
    else if (M < N) return M + SumNumbers(M + 1, N);
    else return N + SumNumbers(M, N +1);
}

Console.WriteLine(SumNumbers(n66, m66));
