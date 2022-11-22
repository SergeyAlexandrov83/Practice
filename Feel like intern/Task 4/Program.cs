Console.WriteLine("Программа покажет максимальное из трех введенных чисел.");
Console.WriteLine("Введите первое число: ");
Double number_one = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Double number_two = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
Double number_three = Convert.ToDouble(Console.ReadLine());
Double max_number = number_one;
if (number_two > max_number)
{
    max_number = number_two;
}
if (number_three > max_number)
{
    max_number = number_three;
}
Console.WriteLine($"Максимальное число {max_number}");