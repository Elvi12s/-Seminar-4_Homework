// Найти натуральный числа
// X1^5+X2^5+x3^5+X4^5=X5^5

int x1 = 1;
int x2 = 1;
int x3 = 1;
int x4 = 1;
int x5 = 1;

bool Count(int x1, int x2, int x3, int x4, int x5)
{
  return (Math.Pow(x1, 5) + Math.Pow(x2, 5) + Math.Pow(x3, 5) + Math.Pow(x4, 5) - Math.Pow(x5, 5) == 0);
}

void Print()
{
  Console.WriteLine($"Числа x1={x1},x2={x2},x3={x3},x4={x4},x5={x5}");
}

for (x5 = 1; x5 < 150; x5++)
{
  if (Count(x1, x2, x3, x4, x5) == true)
  {
    Print();
    goto END;
  }
  for (x1 = 1; x1 < x5; x1++)
  {
    if (Count(x1, x2, x3, x4, x5) == true)
    {
      Print();
      goto END;
    }
    for (x2 = 1; x2 < x1; x2++)
    {
      if (Count(x1, x2, x3, x4, x5) == true)
      {
        Print();
        goto END;
      }
      for (x3 = 1; x3 < x2; x3++)
      {
        if (Count(x1, x2, x3, x4, x5) == true)
        {
          Print();
          goto END;
        }
        for (x4 = 1; x4 < x3; x4++)
        {
          if (Count(x1, x2, x3, x4, x5) == true)
          {
            Print();
            goto END;
          }
        }
      }
    }
  }
}
END:
System.Console.WriteLine("Конец программы");

