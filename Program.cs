try
{
    Console.Write("Введите n:");
    int n = int.Parse(Console.ReadLine());
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double s = 0;
    for (int i = 1; i < n; i++)
    {
        s += Math.Pow(x, i) * Math.Sin(i * Math.PI / 4);
    }
    Console.WriteLine($"s={s:f2}");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
