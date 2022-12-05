int[] array = new int[new Random().Next(1, 100)];
int i = 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(-100, 100);
    i++;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");

for (i=0; i<array.Length; i++)
{
    array[i] *= -1;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
