Console.WriteLine("Программа выведет к какой четверти координатной сетки относятся введенные X и Y.");
Console.WriteLine("X и Y положительные - первая четваерть, X и Y не равны 0!");
Console.WriteLine("Введите X: ");
int valueX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int valueY = Convert.ToInt32(Console.ReadLine());
if (valueX == 0 || valueY == 0)
{
    Console.WriteLine("Мы же договаривались без нулей!");
}
else
{
    if (valueX > 0)
    {
        if (valueY > 0 )
        {
            Console.WriteLine("I четверть");
        }
        else
        {
            Console.WriteLine("II четверть");
        }
    }
    else
    {
        if (valueY > 0 )
        {
            Console.WriteLine("IV четверть");
        }
        else
        {
            Console.WriteLine("III четверть");
        }
    }
}