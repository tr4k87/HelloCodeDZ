Console.WriteLine("Введите значение");
string str = Console.ReadLine();
int sum = 0;
for (int i = 0; i < str.Length; i++)
{   
    sum = sum + Convert.ToInt32(str[i] - '0');
}
Console.WriteLine(sum);
