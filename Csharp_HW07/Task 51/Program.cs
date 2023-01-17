
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(0, 10);
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}

Console.Write("Среднее арифметическое по столбцам:");
for (int j = 0; j < matrix.GetLength(1); j++)
{double average=0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  
  average=average+matrix[i,j];
  Console.Write($"{Math.Round(average/m,2)}, ");
}
Console.WriteLine();