using System;
class Program
{
    static int[] AddArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }
        return array;
    }

    static void WriteArray(int[] array)
    {
        int multi = 0;
        for (int i = 0; i < array.Length; i++)
        {
            multi = array[i] * array[array.Length - 1 - i];
            Console.Write(multi);
        }
    }
    static void Main(string[] argm)
    {
        int[] array = AddArray(5);
        WriteArray(array);
    }
}

