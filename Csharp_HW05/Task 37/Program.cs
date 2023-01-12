
// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Введите размер массива: ");
int Num = Convert.ToInt32(Console.ReadLine());
  int[] array = new int[Num];
  int length=array.Length;
for (int i = 0; i <length; i++)
{
  array[i] = new Random().Next(0,10);
  Console.Write($"{array[i]}, ");
}
System.Console.WriteLine();
int len = length;
void MethodPopolam()
{  for (int i = 0; i < (length / 2 ); i++)
  {
    array[i] = array[(len - 1)] * array[i];
    Console.Write($"{array[i]}, ");
    len--;
  }
}
if (length % 2 == 1)
{
MethodPopolam();
   Console.Write($"{array[(length / 2)]}, ");
}
else 
MethodPopolam();





