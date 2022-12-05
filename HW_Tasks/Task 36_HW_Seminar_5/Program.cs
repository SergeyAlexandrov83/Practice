int[] CreateArray(int size, int leftrange = -100, int rightrange = 100)
{
    int[] massive = new int[size];
    int i = 0;
    while (i <= (massive.Length - 1))
    {
        massive[i] = new Random().Next(leftrange, rightrange);
        i++;
    }
    Console.WriteLine($"Массив: {string.Join(", ", massive)}");
    return massive;
}
int[] array = CreateArray(100);
int i = 0;
int even = 0;
int odd = 0;
while (i <= (array.Length - 1))
{

    if (array[i] % 2 == 0)
    {
        even++;
    }
    else
    {
        odd++;
    }
    i++;
}
Console.WriteLine($"Четных значений элементов в массиве {even}, а нечетных значений элементов в массиве {odd}");
