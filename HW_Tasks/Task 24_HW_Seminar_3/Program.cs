﻿Console.WriteLine("Программа выведет кубы всех чисел от 1 до N!");
Console.WriteLine("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= numberN) 
{
    Console.WriteLine($"Квадрат числа {i} равен {Math.Pow(i, 3)}");
    i ++;
}