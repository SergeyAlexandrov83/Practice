Console.WriteLine("Введите длинну массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
int i = 0;
while (i <= (array.Length - 1))
{
    Console.WriteLine($"Введите элемент массива с индексом [{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    //array[i] = new Random().Next(0, 2);
    i++;
}
Console.WriteLine(string.Join(", ", array));