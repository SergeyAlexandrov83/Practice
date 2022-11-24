Console.WriteLine("Программа найдет третью цифру введенного целого положительногос числа, или сообщит, что она отсутствует.");
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine("Третья цифра отсутствует!");
}
else
{
    int tempNumber = number;
    while (tempNumber > 999)
    {
        tempNumber /= 10; 
    }
    Console.WriteLine($"Третья цифра числа {number} это - {tempNumber % 10}");
}
