Console.WriteLine("Программа покажет максимальную цифру двухзначного числа.");
Console.WriteLine("Введите число в диапазоне [10..99]: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10 && number < 100 )
{
    int numberFirst = number / 10;
    int numberSecond = number % 10;
    if (numberFirst < numberSecond)
    {
        Console.WriteLine(numberSecond);
    }
    else
    {
        Console.WriteLine(numberFirst);
    }
}
else
{
    Console.WriteLine("Введенное число не двухзначное!");
}