static int[,] ArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
static void PrintArray(int[,] array)
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
static void SumMat(int[,] array1, int[,] array2, int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int sum = 0;
            for (int s = 0; s < array.GetLength(1); s++)
            {
                sum += array1[i, s] * array2[s, j];
            }
            Console.Write(sum + " ");
        }
        Console.WriteLine();
    }
}

int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] array = new int[2, 2];
ArrayRandom(array1);
ArrayRandom(array2);
PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
SumMat(array1, array2, array);
