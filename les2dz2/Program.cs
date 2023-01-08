//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число : ");
int num = Convert.ToInt32(Console.ReadLine());
string num_st = Convert.ToString(num);
if (num_st.Length < 3)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine(num_st[2]);
}