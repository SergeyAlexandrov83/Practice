Console.WriteLine("Программа покажет название дня недели восле введения числа.");
Console.WriteLine("Введите число: ");
Double number_one = Convert.ToDouble(Console.ReadLine());
if (number_one == 1) 
{
    Console.WriteLine("Понедельник!");
}
else if (number_one == 2)
{
    Console.WriteLine("Вторник!");
}
else if (number_one == 3)
{
    Console.WriteLine("Среда!");
}
else if (number_one == 4) 
{
    Console.WriteLine("Четверг!");
}
else if (number_one == 5) 
{
    Console.WriteLine("Пятница!");
}
else if (number_one == 6) 
{
    Console.WriteLine("Суббота!");
}
else if (number_one == 7) 
{
    Console.WriteLine("Воскресенье!");
}
else
{
    Console.WriteLine("Такого дня недели не существует!");
}
