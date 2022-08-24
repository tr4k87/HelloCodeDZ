Console.WriteLine("Введите значения b1, k1, b2, k2");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());
var x = (b2 - b1) / (k1 - k2);
var y = (k1*b2 - k2*b1) / (k1 - k2);
Console.WriteLine($"Точка пересечния: [{x}], [{y}]");
