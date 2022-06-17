/* Задача 19: Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

/* Console.WriteLine("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine());


if (N < 10000 || N > 99999)
{
    Console.WriteLine("Вы ввели пятизначное число ");
}
else if (N / 10000 == N % 10 && N / 1000 % 10 == N % 100 / 10)
{
    Console.WriteLine("Да, это палиндром");
}
else 
{
    Console.WriteLine("Нет, это не палиндром");
} */

/* Задача 21: Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* Console.WriteLine("Введите координату X1");
int X1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y1");
int Y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z1");
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X2");
int X2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y2");
int Y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Z2");
int Z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(X2-X1,2)+Math.Pow(Y2-Y1,2)+Math.Pow(Z2-Z1,2));
Console.WriteLine(Math.Round(result)); */

/* Задача 23: Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 1;

while (count <= N)
{
    Console.Write(Math.Pow( count, 3) + " ");
    count ++;
} */

