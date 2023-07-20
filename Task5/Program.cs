// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[4, 4];
        FillSpiral(array);
        PrintArray(array);
    }

    static void FillSpiral(int[,] array)
    {
        int size = array.GetLength(0);
        int value = 1;
        int layer = 0;

        while (value <= size * size)
        {
            for (int i = layer; i < size - layer; i++)
            {
                array[layer, i] = value++;
            }

            for (int i = layer + 1; i < size - layer; i++)
            {
                array[i, size - 1 - layer] = value++;
            }

            for (int i = size - 2 - layer; i >= layer; i--)
            {
                array[size - 1 - layer, i] = value++;
            }

            for (int i = size - 2 - layer; i > layer; i--)
            {
                array[i, layer] = value++;
            }

            layer++;
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j].ToString().PadLeft(2, '0') + " ");
            }
            Console.WriteLine();
        }
    }
}
