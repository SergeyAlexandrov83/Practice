Console.WriteLine("Программа удалит вторую цифру трехзначного числа.");
// Console.WriteLine("Введите число в диапазоне [100..999]: ");
// int number = Convert.ToInt32(Console.ReadLine());
int number = new Random().Next(100,1000);
Console.WriteLine(number);
// if (number >= 100 && number < 1000 )
// {
int numberFirst = number / 100;
int numberThird = number % 10;
Console.WriteLine($"Удалив из числа {number} вторую цифру получим число {numberFirst * 10 + numberThird}");
// }
// else
// {
//     Console.WriteLine("Введенное число не трехзначное!");
// }