/* Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B. */

/* int degree(int numberA, int numberB)
{
    int resalt = 1;
    for (int i = 1; i <= numberB; i++)
    {
        Console.WriteLine("Ответ: " + resalt + " | " + numberA + " | " + numberB);
        resalt = resalt * numberA;
    }
    return resalt;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int deg = degree(numberA, numberB);
Console.WriteLine("Ответ: " + deg); */

/* Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран. */

/* void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 50);
        index++;
    }
}
int[] mass = new int[8];
FillArray(mass);
Console.WriteLine(mass);
for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + " ");
} */

/* Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе. */


/* int getSumNumbersInNumber(string stringNumber)
{
    int result = 0;
    for (int i = 0; i < stringNumber.Length; i++)
    {
        result += charToInt(stringNumber[i]);
    }

    return result;
}

int charToInt(char ch)
{
    return int.Parse(ch.ToString());
}

Console.Write("Введите число: ");

string stringNumber = Console.ReadLine();
int result = getSumNumbersInNumber(stringNumber);

Console.Write("Сумму цифр в числе: " + result); */