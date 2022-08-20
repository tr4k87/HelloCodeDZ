// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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

    static int[] random (int[] array)
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
    static void Sum (int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]%2 == 0)
            {
                sum = sum + array[i];
            }
        }
        Console.Write(sum);
    }
     static void WriteArray(int[] array) // вывод всего массива в троку
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
                
            }
            Console.WriteLine();
        }

    static void Main(string[] argm)
    {
        int[] array = addArray(10);
        WriteArray(array);
        array = random(array);
        WriteArray(array);
        Sum(array);
    }

}