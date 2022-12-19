int[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    int[,] matr = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(leftRange, rightRange +1);
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

int SumMainDiag(int[,] matr)
{
    int sum = 0;
    int min = 0;
    if (matr.GetLength(0) < matr.GetLength(1))
    {
        min = matr.GetLength(0);
    }
    else
    {
        min = matr.GetLength(1);
    }
    for (int i = 0; i < min; i++)
        {
            sum += matr[i, i];
        }
    return sum;
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);
Console.WriteLine(SumMainDiag(matrix));