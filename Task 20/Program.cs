Console.WriteLine("Программа покажет диапазоны возможных координат для введенного номера четверти.");
Console.WriteLine("Введите номер четверти: ");
int quater = Convert.ToInt32(Console.ReadLine());
if (quater < 1 && quater > 4)
{
    Console.WriteLine("Четвертей че-ты-ре!");
}
else
{
    if (quater == 1)
    {
        Console.WriteLine("I четверть, это X > 0 и Y > 0");
    }
    if (quater == 2)
    {
        Console.WriteLine("II четверть, это X > 0 и Y < 0");
    }
    if (quater == 3)
    {
        Console.WriteLine("III четверть, это X < 0 и Y < 0");
    }
    if (quater == 4)
    {
        Console.WriteLine("IV четверть, это X < 0 и Y > 0");
    }
}
