// Напишите программу, которая принимает на вход целое число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.WriteLine("Введите число от 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num/10; //78 = 7 
int num2 = num%10; //78 = 8

if(num1 >num2) {
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}


