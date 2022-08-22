// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
using System;
class Program
{
    static int[] AddArray(int number)
    {
        int[] array = new int[number];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(100, 999);
        }
        return array;
    }
    static void Write(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();
    }

    static void Chet(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum = sum + 1;
            }
        }
        Console.WriteLine(sum);
    }
    static void Main(string[] argm)
    {
        int[] array = AddArray(10);
        Write(array);
        Chet(array);
    }
}
