// Напишите программу, 
// которая на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

System.Console.WriteLine("Enter first number: ");
string strA = Console.ReadLine();
int firstNumber = Convert.ToInt32(strA);

System.Console.WriteLine("Enter second number: ");
string strB = Console.ReadLine();
int secondNumber = Convert.ToInt32(strB);

if (firstNumber > secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
}
else if (firstNumber < secondNumber)
{
    Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
}
else
{
    Console.WriteLine($"Введенные числа равны `{firstNumber}`");
}
