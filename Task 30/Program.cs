Console.WriteLine("Программа выведет кубы всех чисел от 1 до N заканчивающиеся на четную цифру!");
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 1;
double tmp = 0;
double isodd = 0;
while (i <= numberN) 
{
    tmp = Math.Pow(i, 3);
    isodd = tmp % 10;
    if (isodd % 2 == 0)
    {
    Console.WriteLine($"Куб числа {i} равен {tmp} цифра {isodd} - четная!");
    }
    i ++;
}