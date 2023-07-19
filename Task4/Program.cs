// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,,] arr = CreateRandomUniqueArray(2, 2, 2);
        PrintArray(arr);
    }

    // Создание трёхмерного массива с уникальными значениями
    static int[,,] CreateRandomUniqueArray(int dim1, int dim2, int dim3)
    {
        int[,,] array = new int[dim1, dim2, dim3];

        // Создаём список из двузначных чисел
        List<int> numbers = new List<int>();
        for (int i = 10; i < 100; i++)
            numbers.Add(i);

        // Инициализация генератора случайных чисел
        Random rand = new Random();

        for (int i = 0; i < dim1; i++)
        {
            for (int j = 0; j < dim2; j++)
            {
                for (int k = 0; k < dim3; k++)
                {
                    // Выбираем случайное число из списка
                    int index = rand.Next(numbers.Count);

                    // Заполняем ячейку массива и удаляем число из списка
                    array[i, j, k] = numbers[index];
                    numbers.RemoveAt(index);
                }
            }
        }

        return array;
    }

    // Вывод трёхмерного массива с индексами
    static void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
                }
                Console.WriteLine();
            }
        }
    }
}
