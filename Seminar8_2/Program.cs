static int[,] Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
static void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
static void Sum(int[,] array)
{
    int sum = 100;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = temp + array[i, j];
        }
        if (temp < sum)
            {
                index = i;
                sum = temp;
            }
        Console.WriteLine(temp);
    }
    Console.WriteLine($"минимальная сумма в {index+1} строке");
}
int[,] array = new int[4, 3];
Random(array);
Print(array);
Sum(array);