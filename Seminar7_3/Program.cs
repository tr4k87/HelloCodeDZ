using System;
class Program
{
    static void WriteArray(int[,] array)
    {
        Console.Clear();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static int[,] RandomArray(int[,] array)
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
    static void Sred(int[,] array)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum = sum + array[i,j];
            }
            Console.Write($"{Math.Round(sum/3, 1)} ");
            sum = 0;
        }
        Console.WriteLine();
    }
    static void Main(string[] argm)
    {
        
        int[,] array = new int[3, 4];
        RandomArray(array);
        WriteArray(array);
        Console.WriteLine();
        Sred(array);
    }
}