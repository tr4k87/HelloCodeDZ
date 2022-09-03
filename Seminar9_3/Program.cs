Console.WriteLine("Введите значение М");
int M = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Int32.Parse(Console.ReadLine());
int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    if (M > 0 && N > 0) return Akkerman(M - 1, Akkerman(M, N - 1));
    return Akkerman(M , N);
}
Console.WriteLine(Akkerman(M, N));