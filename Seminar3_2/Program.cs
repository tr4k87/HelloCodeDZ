Console.WriteLine("Введите координаты");
var x1 = Convert.ToInt32(Console.ReadLine());
var y1 = Convert.ToInt32(Console.ReadLine());
var z1 = Convert.ToInt32(Console.ReadLine());
var x2 = Convert.ToInt32(Console.ReadLine());
var y2 = Convert.ToInt32(Console.ReadLine());
var z2 = Convert.ToInt32(Console.ReadLine());
var rast = Math.Sqrt((x2 - x1)*(x2-x1) + (y2 - y1)*(y2-y1) + (z2 - z1)*(z2-z1));
Console.WriteLine(Math.Round(rast, 2));
