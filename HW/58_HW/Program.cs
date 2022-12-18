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

void Multiple(int[,] matr1, int[,] matr2, int[,] matr3)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr3[i, j] = matr1[i, j] * matr2[i, j];
        }
    }
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int[,] matrix1 = GetMatrix(rows, columns);
Console.WriteLine("Заданная матрица 1: ");
PrintMatrix(matrix1);
Console.WriteLine();
int[,] matrix2 = GetMatrix(rows, columns);
Console.WriteLine("Заданная матрица 2: ");
PrintMatrix(matrix2);
Console.WriteLine();
int[,] matrix3 = GetMatrix(rows, columns);
Console.WriteLine("Произведение матриц: ");
Multiple(matrix1, matrix2, matrix3);
PrintMatrix(matrix3);