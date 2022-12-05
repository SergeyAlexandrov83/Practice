double[] array = new double[100];
int i = 0;
while (i <= (array.Length - 1))
{
    array[i] = Math.Round(new Random().NextDouble() * 100, 2);
    i++;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
var min = array.Min();
var max = array.Max();
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива равна {max - min}");
