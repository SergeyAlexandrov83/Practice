int[] array = new int[12];
int i= 0;
int even = 0;
int odd = 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 10);
    if (array[i] % 2 == 0)
    {
        even += array[i];
    }
    else 
    {
        odd += array[i];
    }
    i ++;
}
Console.WriteLine($"В массиве: {string.Join(", ", array)} сумма четных значений элементов равнв {even}, а сумма нечетных значений элементов равна {odd}");