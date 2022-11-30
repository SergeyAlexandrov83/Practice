Console.WriteLine("Программа определит произведение всех числел от 1 до N!");
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 1;
for (int i = 2; i <= number; i++)
{
    sum *= i;
}

Console.WriteLine($"Произведение всех числел от 1 до {number} равняется {sum}!");