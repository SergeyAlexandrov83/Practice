double input() {
    Console.WriteLine("Введите первую координату: ");
    double coord1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вторую координату: ");
    double coord2 = Convert.ToDouble(Console.ReadLine());
    double lineDeltaPow2 = Math.Pow(Math.Abs(coord1 - coord2), 2);
    return lineDeltaPow2;
}

Console.WriteLine("Программа найдет длину отрезка между точками в пространстве 2D/3D!");
Console.WriteLine("Введите '2' если работаем в 2D и '3' если работаем в 3D: ");
int workField = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите координаты по оси X: ");
double firstCoordDeltaPow2 = input();
Console.WriteLine("Введите координаты по оси Y: ");
double secondCoordDeltaPow2 = input();
double XY = Math.Sqrt(firstCoordDeltaPow2+secondCoordDeltaPow2);
if (workField == 3)
{
    Console.WriteLine("Введите координаты по оси Z: ");
    double thirdCoordDeltaPow2 = input();
    double XYZ = Math.Sqrt(firstCoordDeltaPow2+secondCoordDeltaPow2+thirdCoordDeltaPow2);
    Console.WriteLine($"Длинна отрезка = {XYZ}");
}
else
{
    Console.WriteLine($"Длинна отрезка = {XY}");
}
