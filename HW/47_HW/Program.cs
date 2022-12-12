double[,] GetMatrix(int rowsCount, int columnsCount, int leftRange=0, int rightRange=50)
{
    double[,] matr = new double[rowsCount, columnsCount];

    Random rand = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.NextDouble() * (rightRange + leftRange) + leftRange;
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]:f2}" + " ");
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
double[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);