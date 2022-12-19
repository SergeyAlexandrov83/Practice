Console.WriteLine("Введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

int Numbers(int a, int b)
{
    if (b < 1)
    {
        return 1;
    }
    b--;
    a *= Numbers(a, b);
    return a;
}

Console.WriteLine(Numbers(a, b));