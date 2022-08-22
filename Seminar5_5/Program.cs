using System;
class Program
{
    static int[] addArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }
    static int[] random(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = new Random().Next(0, i + 1);
            int number = array[j];
            array[j] = array[i];
            array[i] = number;
        }
        return array;
    }
    static void Write(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
        }
        Console.WriteLine();
    }

    static void MinMax(int[] array)
    {
        int min = 1;
        int max = 0;
        int raz = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
            if (array[i] < min)
            {
                min = array[i];
            }
        }
        raz = max - min;
        Console.WriteLine($"Разница между min {min} и max {max} = {raz}");
    }

    static void Main(string[] argm)
    {
        int[] array = addArray(10);
        array = random(array);
        Write(array);
        MinMax(array);
    }
}
