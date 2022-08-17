Console.WriteLine("Значения массива");
string mass = Console.ReadLine();
int j = mass.Length;
string[] array;
array = new string[j];
Console.Write("[");
for (int i = 0; i < j; i++)
{
  Console.Write(mass[i] + ",");
}
Console.Write("]");




