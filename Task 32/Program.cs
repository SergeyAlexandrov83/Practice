int[] array = new int[new Random().Next(1, 1000)];
int i= 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 2);
    i ++;
}
Console.WriteLine(string.Join(", ", array));