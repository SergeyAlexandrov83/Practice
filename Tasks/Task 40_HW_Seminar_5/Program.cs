// Генерация рандомных действительных чисел с нужним количеством знаков после запятой - костыль))
// double[] array = new double[100];
// int i = 0;
// while (i <= (array.Length - 1))
// {
//     array[i] = Math.Round(new Random().NextDouble() * 100, 2);
//     i++;
// }
// Console.WriteLine($"Массив: {string.Join(", ", array)}");
// var min = array.Min();
// var max = array.Max();
// Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива равна {max - min}");

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
int[] array = CreateArray(10);

var min = array[0];
var max = array[0];
var i = 1;
while (i < array.Length - 1)
{
    if (array[i] < min)
    {
        min = array[i];
    }
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}
Console.WriteLine($"Разница между максимальным и минимальным значениями элементов массива равна {max - min}");

