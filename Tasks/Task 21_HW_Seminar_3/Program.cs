Console.WriteLine("Программа проверит является ли введенное число полиндромом!");
Console.WriteLine("Введите число: ");
long number = Convert.ToInt64(Console.ReadLine());
long temp = number;
long poly = 0;
while (temp > 0)
{
    poly *= 10;
    poly += temp % 10;
    temp /= 10;
}
if (number == poly)
{
    Console.WriteLine($"Число {number} полиндром!");
}
else
{
    Console.WriteLine($"Число {number} не полиндром!");
}