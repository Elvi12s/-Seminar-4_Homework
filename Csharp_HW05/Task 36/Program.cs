
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размер массива: ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Num];
int length = array.Length;
int count=0;
for (int i = 0; i <length; i++)
{
  array[i] = new Random().Next(0,10);
  Console.Write($"{array[i]}, ");
  if (i>0 && i%2==0) count=count+array[i];
}
Console.WriteLine();
Console.Write($"Суммма чисел на четных позициях:{count}.");
Console.WriteLine();
