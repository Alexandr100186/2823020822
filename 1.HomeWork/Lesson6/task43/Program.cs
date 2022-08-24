﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[,] kof = new double[2, 2];
double[] crossPoint = new double[2];

void InputCoefficients(){
  for (int i = 0; i < kof.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < kof.GetLength(1); j++)
    {
      if(j==0) Console.Write("Введите коэффициент k: ");
      else Console.Write("Введите коэффициент b: ");
      kof[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] koef)
{
  crossPoint[0] = (koef[1,1] - koef[0,1]) / (koef[0,0] - koef[1,0]);
  crossPoint[1] = crossPoint[0] * koef[0,0] + koef[0,1];
  return crossPoint;
}

void OutputResp(double[,] koeff)
{
  if (koeff[0,0] == koeff[1,0] && koeff[0,1] == koeff[1,1]) 
  {
    Console.Write("\nПрямые совпадают");
  }
  else if (koeff[0,0] == koeff[1,0] && koeff[0,1] != koeff[1,1]) 
  {
    Console.Write("\nПрямые параллельны");
  }
  else 
  {
    Decision(koeff);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputCoefficients();
OutputResp(kof);
