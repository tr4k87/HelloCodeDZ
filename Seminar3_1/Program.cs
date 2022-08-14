Console.WriteLine("Введите пятизначное число");
string pal = Console.ReadLine();
if (pal[0] == pal[4])
{
    if (pal[1] == pal[3])
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("нет");
}