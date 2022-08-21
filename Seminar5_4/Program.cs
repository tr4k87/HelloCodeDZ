// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] number = new int[10];
Random random = new Random();
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    Console.Write((number[i] = random.Next(100, 999)) + ",");

    if (number[i] % 2 == 0)
    {
        sum = sum + 1;
    }
}
Console.WriteLine();
Console.WriteLine(sum);
