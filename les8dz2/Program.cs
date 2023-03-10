// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int SumElements(int[,] array, int i)
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i, j];
  }
  return sum;
}

Console.Write("Введите количество строк в массиве: ");
int pos1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int pos2 = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[pos1, pos2];

CreateArray(array);
WriteArray(array);

int minSum = 0;
int sum = SumElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumElements(array, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"\n{minSum+1} - строкa с наименьшей суммой элементов равной {sum}");