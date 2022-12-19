int[] CreateArray() {
    int[] massive = new int[new Random().Next(1, 100)];
    int i = 0;
    while (i <= (massive.Length - 1))
    {
    massive[i] = new Random().Next(0, 100);
    i++;
    }
    Console.WriteLine($"Массив: {string.Join(", ", massive)}");
    return  massive;
}
int[] array = CreateArray();
Console.WriteLine("Введите число для поиска: ");
int number = Convert.ToInt32(Console.ReadLine());
bool isTrue = false;
for (int i=0; i<array.Length; i++)
{
    if (array[i] == number)
    {
        isTrue = true;
        break;
    }
}
if (isTrue)
{
    Console.WriteLine($"Число {number} присутствует в массиве");
}
else
{
    Console.WriteLine($"Число {number} отсутствует в массиве");
}