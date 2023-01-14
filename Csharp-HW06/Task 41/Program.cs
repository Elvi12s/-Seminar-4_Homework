
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count=0;
void Vvodmassiva()
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-100, 100);
    Console.Write($"{array[i]} ");
    if (array[i] > 0)  count++;
  }
}
Vvodmassiva();
System.Console.WriteLine();
System.Console.WriteLine($"пользователь ввел {count} чисел больше 0");