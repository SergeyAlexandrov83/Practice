int[,] GetMatrix(int rowsCount, int columnsCount)
{
    int[,] matr = new int[rowsCount, columnsCount];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
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

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix = GetMatrix(rows, columns);
PrintMatrix(matrix);