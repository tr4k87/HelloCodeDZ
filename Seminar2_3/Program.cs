Console.WriteLine("Выберите день недели");
Console.WriteLine("1-Понедельник, 2-Вторник, 3-Среда, 4-Четверг, 5-Пятница, 6-Суббота, 7-Воскресенье");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 5)
{
    Console.WriteLine("ДА!!!! Сегодня выходной");
}
else
{
    Console.WriteLine("Увы мой друг, сегодня на работу");
}