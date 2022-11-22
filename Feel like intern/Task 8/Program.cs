Console.WriteLine("Программа покажет все четные целые числа от 1 до N.");
Console.WriteLine("Введите положительное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
// int odd = 2;
// while (odd <= numberN)
// {
//     Console.Write($"{odd}, ");
//     odd += 2;
// }
for (int odd = 2; odd <= numberN; odd += 2)
{
    Console.Write($"{odd}, ");
} 