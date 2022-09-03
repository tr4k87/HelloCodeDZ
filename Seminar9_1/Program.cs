Console.WriteLine("Введите значение М");
int M = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Int32.Parse(Console.ReadLine());
int Sum(int M)
{
    int sum = 0;
    if (M == N) return N;
    return M + Sum(M + 1);
}
Console.Write(Sum(M));