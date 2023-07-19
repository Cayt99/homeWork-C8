// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = GenerateRandomMatrix(2, 2);
        int[,] matrix2 = GenerateRandomMatrix(2, 2);

        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("\nМатрица 2:");
        PrintMatrix(matrix2);

        int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("\nРезультирующая матрица:");
        PrintMatrix(resultMatrix);
    }

    static int[,] GenerateRandomMatrix(int rows, int columns)
    {
        var rand = new Random();
        var matrix = new int[rows, columns];
        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < columns; j++)
            {
                matrix[i, j] = rand.Next(1, 10); 
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (var i = 0; i < matrix.GetLength(0); i++)
        {
            for (var j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            throw new InvalidOperationException("Размерность матрицы не подходит для умножения");
        }

        var result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (var i = 0; i < result.GetLength(0); i++)
        {
            for (var j = 0; j < result.GetLength(1); j++)
            {
                result[i, j] = 0;

                for (var k = 0; k < matrix1.GetLength(1); k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }
}
