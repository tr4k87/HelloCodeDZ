Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int count = 1;
while (a > count)
{
    if (a%2 == 0)
    {
        Console.WriteLine(a);
        a= a - 1;
    }
    else
    {
        a = a - 1;
    }
}
