Console.WriteLine("Введите число");
string chis = Console.ReadLine();
if (chis.Length == 3)
{
    Console.WriteLine(chis[2]);
}
else
{
    Console.WriteLine("Нет третьего числа");
}