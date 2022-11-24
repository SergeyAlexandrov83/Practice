double coorddelta(double n1, double n2) {
    return Math.Abs(n1 - n2);
}
double sqredelta(double n1) {
    return n1 * n1;
}

Console.WriteLine("Программа найдет длину отрезка между точками в пространстве 2D/3D!");
Console.WriteLine("Введите '2' если работаем в 2D и '3' если работаем в 3D: ");
int workField = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите первую координату X: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату X: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите первую координату Y: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите вторую координату Y: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
double sqredeltaX = sqredelta(coorddelta(X1, X2));
double sqredeltaY = sqredelta(coorddelta(Y1, Y2));
double XY = Math.Sqrt(sqredeltaX+sqredeltaY);
if (workField == 3)
{
    Console.WriteLine("Введите первую координату Z: ");
    double Z1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите вторую координату Z: ");
    double Z2 = Convert.ToDouble(Console.ReadLine());
    double sqredeltaZ = sqredelta(coorddelta(Z1, Z2));
    double XYZ = Math.Sqrt(sqredeltaX+sqredeltaY+sqredeltaZ);
    Console.WriteLine($"Длинна отрезка = {XYZ}");
}
else
{
    Console.WriteLine($"Длинна отрезка = {XY}");
}
