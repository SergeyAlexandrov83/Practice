Console.WriteLine("Программа определит сумму цифр в числе!");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int res = number;
int tmp = 0;
int sum = 0;
while (res > 0)
{
    tmp = res % 10;
    sum += tmp;
    res /= 10;
}
Console.WriteLine($"В числе {number} - сумма всех цифр равняется {sum}!");