Console.WriteLine("Программа покажет все целые числа от -N до N.");
Console.WriteLine("Введите положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
// int negativeN = -numberN;
// while (negativeN <= numberN)
// {
//     Console.Write($"{negativeN}, ");
//     negativeN ++;
// }
for (int i = -numberN; i <= numberN; i ++)
{
    Console.Write($"{i}, ");
}