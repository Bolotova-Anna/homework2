// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
int temperarynumber = number/10;
System.Console.WriteLine(temperarynumber%10);



