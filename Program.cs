// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



Console.WriteLine("***Задача 47:***");
int m, n;
Console.Write("Введи кол-во строк: ");
m = int.Parse(Console.ReadLine());
Console.Write("Введи кол-во столбцов: ");
n = int.Parse(Console.ReadLine());
double[,] a = new double[m, n];
Random random = new Random();
Console.WriteLine($"Массив из {m} строк и {n} столбцов: ");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = random.NextDouble() * 100;
        Console.Write("{0,7:F2}", a[i, j]);
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.WriteLine("***Задача 50:***");
int[,] myArr = new int[5, 5];
Random ran = new Random();
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
       myArr[i, j] = ran.Next(0, 100);
       Console.Write("{0,4}", myArr[i, j]);
    }
    Console.WriteLine();
}
Console.WriteLine("Ввведите номер строки элемента: ");
int rowPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите номер столбца элемента: ");
int columnPosition = Convert.ToInt32(Console.ReadLine());

if (rowPosition > 5 || columnPosition > 5 || rowPosition < 0 || columnPosition < 0)
    Console.WriteLine("Такого элемента нет! ");
else 
    Console.WriteLine($"Значение элемента: {myArr[rowPosition, columnPosition]}");


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("***Задача 52:***");
int[,] array = new int[5, 5];
Random rand = new Random();
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
       array[i, j] = rand.Next(0, 100);
       Console.Write("{0,4}", array[i, j]);
    }
    Console.WriteLine();
}
double [] average = new double [array.GetLength(1)];
for (int j = 0; j < array.GetLength(1); j++) 
{
    double sum = 0;
    for (int i= 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    average[j] = sum / array.GetLength(0);
}
Console.WriteLine("Среднее арифметическое элементов в каждом столбце:");
Console.WriteLine("\n" + string.Join("\t", average));
