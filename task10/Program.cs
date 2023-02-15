// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=100 && number<=999)
{
    int temperarynumber = number/10;
    System.Console.WriteLine(temperarynumber%10);
}
else
{
    System.Console.WriteLine("неверно. необходимо было ввести трехзначное число");
}


