// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива: ");
int Num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[Num];
int length = array.Length;
int count=0;
for (int i = 0; i <length; i++)
{
  array[i] = new Random().Next(100,1000);
  Console.Write($"{array[i]}, ");
  if (array[i]%2==0) count++;
}
Console.WriteLine();
Console.Write($"Всего четных чисел :{count}.");