Console.WriteLine("Введите числа b1, k1, b2 и k2: ");
double b1 = Convert.ToDouble(Console.ReadLine());
double k1 = Convert.ToDouble(Console.ReadLine());
double b2 = Convert.ToDouble(Console.ReadLine());
double k2 = Convert.ToDouble(Console.ReadLine());

// y = k1 * x + b1, y = k2 * x + b2

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"Прямые пересекаются в точке: Х= {x}, Y= {y}");