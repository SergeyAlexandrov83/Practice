void ToBinary(int num)
{
    if (num <= 0) return;
    ToBinary(num / 2);
    Console.Write(num % 2);
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
ToBinary(number);