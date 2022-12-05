int[] array = new int[new Random().Next(1, 100)];
int i = 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 100);
    i++;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
int temp = 0;
int left = 0;
int right = array.Length - 1;
while (left < right)
{
    temp = array[left];
    array[left] = array[right];
    array[right] = temp;
    left++;
    right--;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
