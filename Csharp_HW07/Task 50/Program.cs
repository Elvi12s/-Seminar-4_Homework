// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.WriteLine("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(-100, 100);
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}
Console.WriteLine("Введите порядковый номер искомого элемента при сквозной нумерации. Номер первого элемента 0");
int index = Convert.ToInt32(Console.ReadLine());
if (index < (m * n))
  Console.WriteLine(matrix[index / n, index / m]);
else
  Console.WriteLine("В таблице отсутствует запрашиваемый элемент");
