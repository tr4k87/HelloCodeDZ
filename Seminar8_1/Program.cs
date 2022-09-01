static int[,] RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10, 99);
        }
    }
    return array;
}
static void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}
static int[,] Sort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(1) - 1; s++)
            {
                if (array[i, s] < array[i, s + 1])
                {
                    int temp = array[i, s + 1];
                    array[i, s + 1] = array[i, s];
                    array[i, s] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    return array;
}

int[,] array = new int[4, 4];
RandomArray(array);
WriteArray(array);
Sort(array);
WriteArray(array);