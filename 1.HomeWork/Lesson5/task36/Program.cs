// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write($"Введи количество элементов: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Задан массив: ");
    Console.Write("[");
    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

        if (i < randomNumbers.Length - 1) Console.Write($"{randomNumbers[i]}, ");
        else Console.Write(randomNumbers[i]);

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
    Console.Write("]");
    return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 1, 10);

Console.WriteLine($"\nСумма элементов, расположенных в нечетных индексах: {randomNumbers}");
