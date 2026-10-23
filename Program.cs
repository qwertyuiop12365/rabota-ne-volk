//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i < n; i++)
//    {
//        s += Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
//    }
//    Console.WriteLine($"s={s:f2}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}


//вариант 8 базовый уровень

Console.WriteLine("Введите w: ");
double w = double.Parse(Console.ReadLine());
Console.WriteLine("|        x       |       y      |");
Console.WriteLine("---------------------------------");

for (double x = 1; x <= 3; x += 0.2)
{
    double y =Math.Abs(Math.Exp(w) - 2) - Math.Pow(x,2);
    Console.WriteLine($"|      {x:f1}      |      {y:f2}   |");
}
Console.WriteLine("--------------------------------");