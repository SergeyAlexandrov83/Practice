Console.WriteLine("Программа возведет число А в степень В используя цикл!");
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

while (numberB>0) 
{
    numberA *= numberA;
    numberB -= 1;
}
 Console.WriteLine($"{numberA}");