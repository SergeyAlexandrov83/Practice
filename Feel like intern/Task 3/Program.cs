Console.WriteLine("Программа покажет большее и меньшее из двух введенных чисел.");
Console.WriteLine("Введите превое число: ");
Double number_one = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
Double number_two = Convert.ToDouble(Console.ReadLine());
if (number_one < number_two) 
{
    Console.Write("Число ");
    Console.Write(number_one);
    Console.Write(" меньше числа ");
    Console.Write(number_two);
}
else
{
    Console.Write("Число ");
    Console.Write(number_one);
    Console.Write(" больше числа ");
    Console.Write(number_two);
}