// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
Console.WriteLine("введите ваше число");
int number = Convert.ToInt32(Console.ReadLine());
string numberarray = Convert.ToString(number);
int n = numberarray.Length;
if (n > 2)
{
  Console.WriteLine( numberarray[2]);
}
else
{
  Console.WriteLine("третьей цифры нет");
}
