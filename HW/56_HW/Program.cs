int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinSumRow(int[,] matr)
{
    int min = 999999999;
    int numRow = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i,j];
        }
        if (sum < min)
        {
            min = sum;
            numRow = i;
        }
    }
    return numRow;
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
Console.WriteLine("Заданная матрица: ");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Номер строки с наименьшей суммой элементов: ");
Console.WriteLine(MinSumRow(matrix)); 
