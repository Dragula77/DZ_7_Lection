﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double[,] GeneretaMatrix(int rows, int cols)
{
    Random rand = new Random();
    double[,] matrix = new double[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble() * 2.0;
        }
    }
    return  matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(Math.Round(matrix[i, j],2) + "\t");
        }
        System.Console.WriteLine();
    }
}
int rows = ReadInt("Введите колличество строк матрицы: ");
int cols = ReadInt("Введите колличество столбцов: ");
System.Console.WriteLine();
var myMatrix = GeneretaMatrix(rows, cols);
PrintMatrix(myMatrix);
