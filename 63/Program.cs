Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

void Numbers(int n)
{
    if (n != 0)
    {
        Numbers(n - 1);
        Console.Write(n + " ");
    }
}

Numbers(n);