Console.WriteLine("Программа ответит является ли введенное число четным.");
Console.WriteLine("Введите число: ");
Double number = Convert.ToDouble(Console.ReadLine());
if (number % 2 == 0)
{
    Console.WriteLine($"Число {number} является четным!");
}
else
{
    Console.WriteLine($"Число {number} является нечетным!");
}