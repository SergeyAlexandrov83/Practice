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
double x1x2DeltaPow2 = input();
Console.WriteLine("Введите координаты по оси Y: ");
double y1y2DeltaPow2 = input();
if (workField == 3)
{
    Console.WriteLine("Введите координаты по оси Z: ");
    double z1z2DeltaPow2 = input();
    double XYZ = x1x2DeltaPow2+y1y2DeltaPow2+z1z2DeltaPow2;
    Console.WriteLine($"Длинна отрезка = {Math.Sqrt(XYZ)}");
}
else
{
    double XY = x1x2DeltaPow2+y1y2DeltaPow2;
    Console.WriteLine($"Длинна отрезка = {Math.Sqrt(XY)}");
}
