
String x = Console.ReadLine();
if (x.Length > 10)
{
    Console.WriteLine("Tekst dluzszy od 10");
}else if (x.Length < 10)
{
    Console.WriteLine("Tekst krotszy od 10");
}
else
{
    Console.WriteLine("Tekst jest rowny 10");
}

if (x.First() == 't')
{
    Console.WriteLine("Tekst jest zapisywalny w t-sposob");
}

static double CalculateAverage(int[] values)
{
    double sum = 0;
    return values.Sum(x => (sum += x)) / values.Length;
    
}

static double CalculateMax(int[] values)
{
    double max = values[0];
    return values.Max();
}

static double CalculateMin(int[] values)
{
    double min = values[0];
    return values.Min();
}