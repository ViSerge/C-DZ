// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Convert.ToString(Console.ReadLine()); //ввод чисел в виде строки

int [] arrayOfNumbers = seriesOfNumbers.Replace(" ", "").Split(',').Select(int.Parse).ToArray(); //удаление пробелов в числовой строке, разбивка строки на числа и преобразование строковых чисел в целые числа

string arrayStr = String.Join(", ",arrayOfNumbers); //объединение чисел в строку

Console.WriteLine("[{0}]", arrayStr);