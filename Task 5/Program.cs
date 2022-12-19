Console.WriteLine("Программа вычислит значение функции y=x(a) на основе ввода числа а.");
Console.WriteLine("Введите число а: ");
Double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите '1' чтоб вычислить f = a * a: ");
Console.WriteLine("Введите '2' чтоб вычислить f = a * a * a: ");
Console.WriteLine("Введите '3' чтоб вычислить f = a + a: ");
Console.WriteLine("Введите '4' чтоб вычислить f = a / 2: ");
Double number_one = Convert.ToDouble(Console.ReadLine());
if (number_one == 1) 
{
    Console.WriteLine($"f = a * a -> f = {numberA * numberA}");
}
else if (number_one == 2)
{
    Console.WriteLine($"f = a * a * a -> f = {numberA * numberA * numberA}");
}
else if (number_one == 3)
{
    Console.WriteLine($"f = a + a -> f = {numberA + numberA}");
}
else if (number_one == 4) 
{
    Console.WriteLine($"f = a / 2 -> f = {numberA / 2}");
}
else
{
    Console.WriteLine("Такогой команды не существует!");
}
