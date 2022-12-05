int[] CreateArray()
{
    int[] massive = new int[new Random().Next(1, 100)];
    int i = 0;
    while (i <= (massive.Length - 1))
    {
        massive[i] = new Random().Next(100, 1000);
        i++;
    }
    Console.WriteLine($"Массив: {string.Join(", ", massive)}");
    return massive;
}
int[] array = CreateArray();
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
