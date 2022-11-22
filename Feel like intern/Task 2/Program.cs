Console.WriteLine("Программа покажет большее и меньшее из двух введенных чисел.");
Console.WriteLine("Введите превое число, a = ");
Double number_one = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число, b = ");
Double number_two = Convert.ToDouble(Console.ReadLine());
if (number_one < number_two) 
{
    Console.Write("Число ");
    Console.Write(number_one);
    Console.Write(" меньше числа ");
    Console.WriteLine(number_two);
    Console.Write("max = ");
    Console.Write(number_two);
    Console.Write(", min = ");
    Console.Write(number_one);
}
else
{
    Console.Write("Число ");
    Console.Write(number_one);
    Console.Write(" больше числа ");
    Console.WriteLine(number_two);
    Console.Write("max = ");
    Console.Write(number_one);
    Console.Write(", min = ");
    Console.Write(number_two);
}
