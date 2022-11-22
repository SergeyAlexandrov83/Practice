Console.WriteLine("Программа покажет большее и меньшее из двух введенных чисел.");
Console.WriteLine("Введите превое число, a = ");
Double number_one = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число, b = ");
Double number_two = Convert.ToDouble(Console.ReadLine());
if (number_one < number_two) 
{
    Console.Write($"Число {number_one} меньше числа {number_two}");
    Console.Write($"max = {number_two}, min = {number_one}");
}
else
{
    Console.Write($"Число {number_one} больше числа {number_two}");
    Console.Write($"max = {number_one}, min = {number_two}");
}
