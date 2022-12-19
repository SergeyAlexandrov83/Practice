Console.WriteLine("Программа возведет число А в степень В используя цикл!");
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int answer = numberA;
int iterator = numberB;
while (iterator > 1)
{
    answer *= numberA;
    iterator -= 1;
}
Console.WriteLine($"{numberA} в степени {numberB} равняется {answer}");