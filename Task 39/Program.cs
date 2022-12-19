int[] array = new int[new Random().Next(1, 100)];;
int i = 0;
while (i <= (array.Length - 1))
{
    array[i] = new Random().Next(0, 100);
    i++;
}
Console.WriteLine($"Массив: {string.Join(", ", array)}");
int[] multarray;
if ((array.Length/2) % 2 == 0)
{
    multarray = new int[(array.Length / 2)];
}
else
{
    multarray = new int[(array.Length / 2) + 1];
}
int left = 0;
int right = array.Length - 1;

while (left <= right)
{
    if (left == right)
    {
        multarray[left] = array[left];
        break;
    }
    multarray[left] = array[left] * array[right];
    left++;
    right--;
}
Console.WriteLine($"Массив: {string.Join(", ", multarray)}");