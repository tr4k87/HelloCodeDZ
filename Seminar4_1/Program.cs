Console.WriteLine("Введите значения");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
for (int i = 0; i < b; i++)
{
   c = c * a;
}
Console.WriteLine($"Натуральная степень 2х чисел = {c}");