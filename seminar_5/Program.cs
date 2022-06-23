/* Задача 34: Задайте массив заполненный случайными
положительными трёхзначными числами. Напишите
программу, которая покажет количество чётных чисел в
массиве. */

/* void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[3];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
Print(mass);

int QuantityPositive(int[] arr)
{
    int quantity = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}

int quantity = QuantityPositive(mass);
Console.WriteLine($"Количество чётных чисел в массиве: {quantity}"); */

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 [3, 7, 23, 12] -> 19
 [-4, -6, 89, 6] -> 0 */

/* Console.Write("Введи количество элементов массива: ");
int numberElements = Convert.ToInt32(Console.ReadLine()); 

int RandomNumbers(int numberElements, int min, int max)
  {
  int[] randomNumbers = new int[numberElements];
  int sumElements = 0;
  Console.Write("Новый массив: ");

    for (int i = 0; i <randomNumbers.Length; i++ ){
      randomNumbers[i] = new Random().Next(min, max);

      Console.Write(randomNumbers[i] + " ");

      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumbers[i];
      }
    }
  return sumElements;
  }

int randomNumbers =  RandomNumbers(numberElements, 10, 100);

Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях: {randomNumbers}"); */

/* Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным
элементов массива. */

/* void Print(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

double[] mass = new double[4];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next() + new Random().NextDouble();
}
Print(mass);

double min = mass [0];
double max = mass [0];

for (int i = 0; i < mass.Length; i++)
{
    if(mass [i]< min) min = mass [i];
    if(mass [i]> max) max = mass [i];
}
double diff = max - min; 

 Console.WriteLine("мин элемент: " +min);

 Console.WriteLine("макс элемент: " +max);

 Console.WriteLine("разница между макс и мин элементами: " +diff); */