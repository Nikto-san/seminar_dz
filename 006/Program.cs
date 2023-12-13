// Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2


// Console.WriteLine("Введите натульное число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num < 10)
// {
//     Console.WriteLine(num);
// }
// else 
// {
//     while (num > 0) 
//     {
//         int num1 = num%10;
//         num /= 10;
//         if(num > 0)
//         {
//             Console.Write(num1 + ",");
//         }
//         else 
//         {
//             Console.Write(num1);
//         }
//     }
// }



using System;
class Program
{
static void Main()
{
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
{
Console.WriteLine(N);
}
else
{
while (N > 0)
{
int currentDigit = N % 10;
N /= 10;
if (N > 0)
{
Console.Write(currentDigit + ",");
}
else
{
Console.WriteLine(currentDigit);
}
}
}
}}