// Задача 64 вывести натур числа от M до N
int  InNum(int N, int M)
{
if(N<=0) N=1;
if(M<=0) M=1;
if(M>N)
{
Console.Write(N+" ");
return InNum(M,N+1);
}
else if (M<N)
{
Console.Write(M+" ");
return InNum(M+1,N); 
}
else
return M;
}

Console.WriteLine("Введите 1-ое число: ");
int num1= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(InNum(num1,num2));