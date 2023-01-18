// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine());
Random random = new Random();
int[,] arr = new int[pos1, pos2];
Console.WriteLine("Исходный массив: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
    arr[i, j] = random.Next(1, 10);
    Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
    sum += arr[i, j];
    }
    double ArithmeticMean = Convert.ToDouble(sum) / Convert.ToDouble(pos2);
    Console.Write(ArithmeticMean);
    Console.Write(" ");
}