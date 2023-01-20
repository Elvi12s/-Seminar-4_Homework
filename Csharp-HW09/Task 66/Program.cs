
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int  InNum(int N, int M)
{
if(N<=0) N=1;
if(M<=0) M=1;
if(M>N) return N+InNum(M,N+1);
else if (M<N) return M+ InNum(M+1,N); 
else return N;
}
Console.WriteLine("Введите 1-ое число: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(InNum(num1,num2));