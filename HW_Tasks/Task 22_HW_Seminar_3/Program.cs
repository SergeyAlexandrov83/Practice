// Успел)) Интересно я сам пойму то тут написано через месяц? xD
double input()
{
    Console.WriteLine("Введите первую координату: ");
    double coord1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вторую координату: ");
    double coord2 = Convert.ToDouble(Console.ReadLine());
    double delta = Math.Pow((coord1 - coord2), 2);
    return delta;
}
Console.WriteLine("Программа найдет длину отрезка между точками в пространстве 3D!");
Console.WriteLine("Введите координаты по оси X: ");
double deltaX = input();
Console.WriteLine("Введите координаты по оси Y: ");
double deltaY = input();
Console.WriteLine("Введите координаты по оси Z: ");
double deltaZ = input();
double AB = deltaX + deltaY + deltaZ;
Console.WriteLine($"Длинна отрезка = {Math.Sqrt(AB)}");