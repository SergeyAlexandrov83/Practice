Console.WriteLine("Программа возведет число А в степень В используя цикл!");
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int answer = numberA;
while (numberB > 1)
{
    answer *= numberA;
    numberB -= 1;
}
Console.WriteLine(answer);