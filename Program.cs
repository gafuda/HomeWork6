// Показать двумерный массив размером m×n заполненный вещественными числами
// Console.Clear();
// System.Console.WriteLine();

// double[,] GetTableDouble(int m, int n)
// {
//     double[,] table = new double[m, n];
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().NextDouble() * 100;
//         }
//     }
//     return table;
// }

// void PrintTable(double[,] tab)
// {
//     for (int i = 0; i < tab.GetLength(0); i++)
//     {
//         for (int j = 0; j < tab.GetLength(1); j++)
//         {
//             System.Console.Write(tab[i, j] + "    ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int m = 8;
// int n = 4;
// double[,] TableDouble = GetTableDouble(m, n);
// PrintTable(TableDouble);

// void FillArray(double[,] matr)
// { for (int i = 0; i < m; i++)
//  { for (int j = 0; j < n; j++)
//  { matr[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);}}}
// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);

// Задать двумерный массив следующим правилом: Aₘₙ = m+n
// int[,] GetMatrix(int row, int col)
// {
//     int[,] matr = new int[row, col];
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i, j] = i + j + 2;
//         }
//     }
//     return matr;
// }

// void PrintTable(int[,] tab)
// {
//     for (int i = 0; i < tab.GetLength(0); i++)
//     {
//         for (int j = 0; j < tab.GetLength(1); j++)
//         {
//             System.Console.Write(tab[i, j] + "   ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = new Random().Next(5, 11);
// int col = new Random().Next(10, 16);

// int[,] table = GetMatrix(row, col);
// PrintTable(table);

// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// Console.Clear();
// System.Console.WriteLine();

// int[,] GetArray(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(min, max);
//         }
//     }
//     return array;
// }

// int[,] ChangeToSquareEvenIndex(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0) arr[i, j] *= arr[i, j];
//             else arr[i, j] = arr[i, j];
//         }
//     }
//     return arr;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10) System.Console.Write($" {array[i, j]}   ");
//             else System.Console.Write($"{array[i, j]}   ");
//         }
//         System.Console.WriteLine();
//     }
// }

// int row = 10;
// int col = 20;
// int min = 1;
// int max = 10;

// int[,] mainArray = GetArray(row, col, min, max);
// PrintArray(mainArray);
// System.Console.WriteLine("--------");
// int[,] chagedArray = ChangeToSquareEvenIndex(mainArray);
// PrintArray(chagedArray);