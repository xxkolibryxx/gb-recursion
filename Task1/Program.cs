void PositiveNumbersBetweenSpace(int m, int n)
{
    if (m <= n)
    {
        Console.WriteLine(m);
        PositiveNumbersBetweenSpace(m + 1, n);
    }
}

Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

PositiveNumbersBetweenSpace(m, n);