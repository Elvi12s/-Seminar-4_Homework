// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] BubbleSort(int[,] mas)
{
  int temp;
  for (int z = 0; z < mas.GetLength(0); z++)
  {
    for (int l = (mas.GetLength(1) - 2); l >= 0; l--)
    {
      for (int r = (mas.GetLength(1) - 1); r >= 0; r--)
      {
        if (mas[z, r] > mas[z, l])
        {
          temp = mas[z, l];
          mas[z, l] = mas[z, r];
          mas[z, r] = temp;
        }
      }
    }
  }
  return mas;
}

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
BubbleSort(matrix);
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}
