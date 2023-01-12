// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива: ");
int Num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[Num];

for (int i = 0; i < array.Length; i++)
{
  array[i] = Math.Round(new Random().NextDouble()*100, 2);
  Console.Write($"{array[i]}, ");
}

double max=array[0];
double min=array[0];
for (int i = 0; i < array.Length; i++)
{
  if (array[i] < min) min = array[i];
  else if (array[i] > max) max = array[i];
}
double dif = Math.Round((max - min), 2);
Console.WriteLine();
Console.WriteLine($" Разница между max и min= {dif}");