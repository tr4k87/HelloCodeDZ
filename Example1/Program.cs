int max = 0;
Console.WriteLine("Введите первое число ");
int a =Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число ");
int b =Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    max = b;
}
else if (b < a)
{
    max = a;
}
Console.Write("Максимальное значение ");
Console.WriteLine(max);