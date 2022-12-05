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
// 0 - четный или не четный?
int i = 0;
int sum = 0;
while (i <= (array.Length - 1))
{

    if (i % 2 != 0)
    {
        sum += array[i];
    }
    i++;
}
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях массива {sum}");