Console.WriteLine("Программа определит произведение всех числел от 1 до N!");
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
double mult = 1;
if (number > 0)
{
    for (int i = 2; i <= number; i++)
        {
            mult *= i;
        }
    Console.WriteLine($"Произведение всех числел от 1 до {number} равняется {mult}!");
}
else 
{
    Console.WriteLine($"Введите положительное число!");
}

