Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int m, int n)
{
    if (n < m)
    {
        return;
    }
    Numbers(m, n - 1);
    Console.Write(n + "  ");
}
Numbers(m, n);