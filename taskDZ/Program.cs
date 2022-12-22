// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine(" Напишите ваше случайное число : ");

{
var n = Math.Abs (Convert.ToInt32(Console.ReadLine()));
while (n >= 100)
{
n /= 10;
}
var r = n % 10;
Console.WriteLine(r);
}