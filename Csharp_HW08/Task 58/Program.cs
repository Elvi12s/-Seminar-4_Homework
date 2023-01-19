



// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] EnterMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    matrix[i, j] = new Random().Next(0, 10);
    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}
return matrix;
}
void PrintMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
  for (int j = 0; j < matrix.GetLength(1); j++)
  {

    Console.Write($"{matrix[i, j]} ");
  }
  Console.WriteLine();
}
}
Console.WriteLine("Введите размер m матрицы 1: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n матрицы 1: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер m матрицы 2: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n матрицы 2: ");
int n1 = Convert.ToInt32(Console.ReadLine());
if(n!=m1)
Console.WriteLine("Матрицы нельзя перемножить ");
else{
int[,] array= new int[m,n];
int[,] array1= new int[m1,n1];
int[,] mult= new int[m,n1];


EnterMatrix(array);
System.Console.WriteLine();
EnterMatrix(array1);
System.Console.WriteLine();
for (int i = 0; i < mult.GetLength(0); i++)
{
  for (int j = 0; j < mult.GetLength(1); j++)
        {for (int k = 0; k < mult.GetLength(0); k++)
      mult[i,j]=mult[i,j]+array[i,k]*array1[ k,j];
  }}

System.Console.WriteLine();
PrintMatrix(mult);
}