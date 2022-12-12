Console.WriteLine("Введите 3 числа - которые соотвктствуют длинам сторон треугольника: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("Такой треугольник может существовать");
}
else
{
    Console.WriteLine("Такой треугольник не может существовать");
}