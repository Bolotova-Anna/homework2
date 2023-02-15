// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
Console.WriteLine("введите число от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7) 
{
    System.Console.WriteLine("да");
}
else if (number >=1 && number <=5) 
{
    System.Console.WriteLine("нет");
}
else 
{
    System.Console.WriteLine("такого дня недели не существует");
}
