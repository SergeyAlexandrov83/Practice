Console.WriteLine("Программа выяснит кратно ли первое введенное число второму введенному числу.");
Console.WriteLine("Введите первое целое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne % numberTwo == 0)
{
    Console.WriteLine($"Числа {numberOne} и {numberTwo} кратны!");
}
else
{
    Console.WriteLine($"Число {numberOne} не кратно числу {numberTwo}, остаток {numberOne % numberTwo}");
}