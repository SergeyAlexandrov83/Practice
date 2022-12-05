int[] array = new int[100];
int i = 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 100);
    i++;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
int[] multarray = new int[array.Length / 2];
int left = 0;
int right = array.Length - 1;
int iter = 0;
while (left < right)
{
    multarray[iter] = array[left] * array[right];
    left++;
    right--;
    iter++;
}
Console.WriteLine($"Массив: {string.Join(", ", multarray)}");