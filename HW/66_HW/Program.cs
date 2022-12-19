Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

int Numbers(int m, int n)
{
    if (n == m)
    {
        return m;
    }
    return n + Numbers(m, n - 1); 
}

Console.WriteLine(Numbers(m, n));