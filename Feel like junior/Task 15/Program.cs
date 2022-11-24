Console.WriteLine("Программа проверит кратно ли введенное число 7 и 23.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 ==0)
{
    Console.WriteLine($"Число {number} кратно 7 и 23!");
}
else
{
    Console.WriteLine($"Число {number} не кратно одновременно 7 и 23!");
}