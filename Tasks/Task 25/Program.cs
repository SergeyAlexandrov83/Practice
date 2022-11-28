Console.WriteLine("Программа найдет сумму всех чисел от 1 до A!");
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int i = 1;
int summ = 0;
while (i <= numberA) 
{
    summ += i;
    i ++;
}
Console.WriteLine($"Сумма чисел от 1 до А равна  {summ}");