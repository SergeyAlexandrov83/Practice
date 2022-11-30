Console.WriteLine("Программа определит количество цифр в числе!");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = number;
int count = 0;
while (res > 0) 
{
    count ++;
    res /= 10;
}
Console.WriteLine($"В числе {number} - {count} цифр(ы)!");