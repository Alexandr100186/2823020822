// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)   //строки row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)   // столбцы col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)

{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            // if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 3}, ");
            // else Console.Write($"{matrix[i,j], 3}");
            Console.Write (j < matrix.GetLength(1) - 1 ? $"{matrix[i,j], 3}," : $"{matrix[i,j], 3}");
        }
        Console.WriteLine("]");
    }
Console.WriteLine(" ");
}

void ReplacementString(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int replacement = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = replacement;
    }
}

int[,] matrix = CreateMatrixRndInt(4, 5, 0, 10);
PrintMatrix(matrix);
ReplacementString(matrix);
PrintMatrix(matrix);