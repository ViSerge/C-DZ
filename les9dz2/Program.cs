// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N = ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < M)
{
    int temp = N;
    N = M;
    M = temp;
}

int sum = 0;

int count = M;
while (count <= N)
{
    sum += count;
    count ++;
}

Console.WriteLine($"Сумма равна {sum}");