Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
while (N > 0)
{
    Console.WriteLine(Math.Pow(N, 3));
    N = N - 1;
}

