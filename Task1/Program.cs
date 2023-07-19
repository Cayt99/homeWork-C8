// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[,] array = GenerateRandomArray(3, 4);
        PrintArray("Задан массив:", array);
        
        array = SortArrayRowsDescending(array);
        PrintArray("Отсортированный массив:", array);
    }

    static int[,] GenerateRandomArray(int rows, int columns)
    {
        Random random = new Random();
        int[,] array = new int[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = random.Next(-1000, 1001);
            }
        }
        return array;
    }

    static int[,] SortArrayRowsDescending(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int[] row = new int[columns];
            for (int j = 0; j < columns; j++)
            {
                row[j] = array[i, j];
            }
            Array.Sort(row);
            Array.Reverse(row);
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = row[j];
            }
        }
        return array;
    }

    static void PrintArray(string message, int[,] array)
    {
        Console.WriteLine(message);
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
