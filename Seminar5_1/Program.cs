using System;
class Program
{
    static int[] CreaterArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    static int[] RandomArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = new Random().Next(0, i+1);
            int number = array[j];
            array[j] = array[i];
            array[i] = number;
        }
        return array;
    }

    static void WriteArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>10)
                {
                    if (array[i] < 99)
                    {
                        Console.Write(array[i] + ",");  
                    }
                }
            }   
        Console.WriteLine();
    }
    static void Main (string[] argm)
    {
        int[] array = CreaterArray(123);
        array = RandomArray(array);
        WriteArray(array);
    }
}