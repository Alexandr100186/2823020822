// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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

int[,] ReplacementString(int[,] matrix)
{
    int[,] matrixOne = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          matrixOne[i, j] = matrix[j, i];  
        }
    }
    return matrixOne;
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(matrix);
int[,] matrixTwo = ReplacementString(matrix);
PrintMatrix(matrixTwo);