Console.WriteLine("Программа покажет название дня недели восле введения числа.");
Console.WriteLine("Введите число: ");
Double number = Convert.ToDouble(Console.ReadLine());
if (number > 0 && number < 6) 
{
    Console.WriteLine("Иди работать!");
}
else if (number == 6) 
{
    Console.WriteLine("Суббота - а суббота - выходной!");
}
else if (number == 7) 
{
    Console.WriteLine("Воскресенье - а воскресенье - выходной!");
}
else
{
    Console.WriteLine("Такого дня недели не существует, поэтому иди работать!");
}