using System;
class Program
{
    static void WriteArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j]} ");
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
                array[i,j] = new Random().Next(10,100);
            }
        }
        return array;
    }
    static void IndexArray(int[,] array)
    {
        Console.WriteLine("Введите индекс");
        int chis = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == chis)
                {
                    Console.WriteLine(chis);
                }
                else
                {
                    Console.WriteLine("Нет такого значения");
                }
            }   
        }
         
    }
    static void Main(string[] argm)
    {
        int[,] array = new int[3,4];
        RandomArray(array);
        WriteArray(array);
        IndexArray(array);
    }
}