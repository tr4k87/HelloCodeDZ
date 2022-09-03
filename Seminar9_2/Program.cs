// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.WriteLine("Введите значение М");
int M = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Int32.Parse(Console.ReadLine());
void Nat(int M)
{
    if (M > N) return;
    Console.Write(M + " ");
    Nat(M + 1);
}
Nat(M);