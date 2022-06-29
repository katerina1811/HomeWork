/* Задача 47: Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

/* void PrintDouble(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
double[,] mass = new double[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().NextDouble() * 20 - 15;
    }
}

PrintDouble(mass);
Console.WriteLine();
PrintDouble(mass); */

/* Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3. */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t"); 
        }
        Console.WriteLine();
    }

}
int m = 3, n = 3;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++) 
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

int[] tmp = new int[mass.GetLength(0)];
for (int x = 0; x < mass.GetLength(0); x++) {
    for (int y = 0; y < mass.GetLength(1); y++) {
        tmp[y] += mass[x, y];
    }
}
float count = mass.GetLength(0);
for (int i = 0; i < tmp.Length; i++) {
    float res = tmp[i] / count;
    Console.WriteLine($"В столбце под индексом {i} | Cреднеарифметическое = {res}"); 
}
 */


/* Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

/* void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }

}
int m = 3, n = 4;
int[,] mass = new int[m, n];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(0, 10);
    }
}
Print(mass);
Console.WriteLine();

Console.Write("Введите позицию X: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x >= mass.GetLength(0))
{
    Console.WriteLine("Позиция X слишком большая");
    return;
}

Console.Write("Введите позицию Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (y >= mass.GetLength(1))
{
    Console.WriteLine("Позиция Y слишком большая");
    return;
}

Console.WriteLine($"На позициях {x} и {y} находится элемент: {mass[x, y]}"); */
