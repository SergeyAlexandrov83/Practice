Console.WriteLine("Программа ответит является ли первое введенное число квадратом второго введенного числа.");
Console.WriteLine("Введите превое число: ");
double number_one = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double number_two = Convert.ToDouble(Console.ReadLine());
// Variant 1
// if (number_one * number_one == number_two || number_two * number_two == number_one) 
// {
//     Console.Write($"Да, является!");
// }
// else
// {
//     Console.Write($"Нет, не является!");
// }
// Variant 2
if (number_two * number_two == number_one) 
{
    Console.Write($"Число {number_one} является квадратом числа {number_two}");
}
else
{
    Console.Write($"Число {number_one} не является квадратом числа {number_two}");
}
if (number_one * number_one == number_two) 
{
    Console.Write($"Число {number_two} является квадратом числа {number_one}");
}
else
{
    Console.Write($"Число {number_two} не является квадратом числа {number_one}");
}
