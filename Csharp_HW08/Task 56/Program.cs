
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int sum;
int[] array = new int[n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(0, 10);
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
  sum = 0;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    sum = sum + matrix[i, j];
    array[i] = sum;
  }
}
Console.WriteLine();

int index = 0;
int min = array[0];
for (int i = 0; i < array.Length; i++)
{
if (array[i] < min)
{
 min = array[i];
 index=i;
}}
Console.Write($"Наименьшая сумма -  строка № {index+1}  ");
Console.WriteLine();