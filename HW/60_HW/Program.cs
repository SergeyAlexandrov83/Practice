int[,,] GetMatrix(int rowsCount, int columnsCount, int zCount, int leftRange = 10, int rightRange = 100)
{
    int[,,] matr = new int[rowsCount, columnsCount, zCount];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = leftRange;
                leftRange++;
            }
        }
    }
    return matr;
}

int GetNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write(matr[i, j, k] + " (" + i + ", " + j + ", " + k + ")     ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int rows = GetNumber("Число строк: ");
int columns = GetNumber("Число столбцов: ");
int zs = GetNumber("Число столбцов: ");
if (rows*columns*zs < 90)
{
    int[,,] matrix = GetMatrix(rows, columns, zs);
    PrintMatrix(matrix);
}
else
{
    Console.WriteLine("Не хватает 2-х значных значений!");
}