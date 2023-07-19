// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        int[,] array = CreateRandomArray(4, 4);
        PrintArray(array);
        int rowWithMinSum = FindRowWithMinSum(array);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {rowWithMinSum + 1}");
    }

    public static int[,] CreateRandomArray(int rows, int cols)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(1, 10);
            }
        }
        return array;
    }

    public static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int rowWithMinSum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int rowSum = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                rowWithMinSum = i;
            }
        }
        return rowWithMinSum;
    }
}
