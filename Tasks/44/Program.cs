Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[number];
arr[0] = 0;
arr[1] = 1;
for (int i = 2; i < number; i++)
{
    arr[i] = arr[i - 2] + arr[i - 1];
}

Console.WriteLine(string.Join(", ", arr));