// Задача 50. Напишите программу, которая
//  на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента 
//  или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите номер строки (до 5)");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца(до 5)");
int col = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[5, 5];

void FillMatrixRandomNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 100) / 10;
        }
    }
}

void PrintMatrixSearchElemPos(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(j < matrix.GetLength(1) - 1 ? $"{matrix[i, j],3}," : $"{matrix[i, j],3}");
        }
        Console.WriteLine("]");
    }
}

void MatrixSearchElementPos(int[,] matrix)
{
    Console.WriteLine();
    if (row > numbers.GetLength(0) || col > numbers.GetLength(1))
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
    else Console.WriteLine($"Значение элемента в {row} строке и {col} столбце: {numbers[row - 1, col - 1]}");
}

FillMatrixRandomNumbers(numbers);
PrintMatrixSearchElemPos(numbers);
MatrixSearchElementPos(numbers);