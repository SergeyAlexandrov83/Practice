int[] CreateArray()
{
    int[] massive = new int[123];
    int i = 0;
    while (i <= (massive.Length - 1))
    {
        massive[i] = new Random().Next(0, 1000);
        i++;
    }
    Console.WriteLine($"Массив: {string.Join(", ", massive)}");
    return massive;
}
int[] array = CreateArray();
int i = 0;
int apple = 0;
while (i <= (array.Length - 1))
{

    if (array[i] >= 10 && array[i] < 100)
    {
        apple++;
    }
    i++;
}
Console.WriteLine($"В массиве {apple} элементов со значением в промежутке [10..99]");
