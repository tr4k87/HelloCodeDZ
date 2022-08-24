using System;
class Program
{
    static int[] AddArray(string Array)
    {
        string[] nums = Array.Split(",", StringSplitOptions.RemoveEmptyEntries);
        int[] res = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            res[i] = int.Parse(nums[i]);
        }
        return res;
    }
    static void Write(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
        }
        Console.WriteLine();
    }
    static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum = sum + 1;
            }
        }
        return sum;
    }
    static void Main(string[] argm)
    {
        Console.WriteLine("Введите через запитую значения");
        string n = Console.ReadLine();
        int[] array = AddArray(n);
        Write(array);
        Console.WriteLine($"Количество элементов > 0 = {Sum(array)}");
    }
}
