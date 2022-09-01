static int[,,] RandomArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(2); s++)
            {
                array[i,j,s] = new Random().Next(10,99);
            }
        }
    }
    return array;
}
static void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = 0; s < array.GetLength(0); s++)
            {
                Console.Write($"{array[i,j,s]} ({i}{j}{s}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] array = new int[2,2,2];
RandomArray(array);
PrintArray(array);