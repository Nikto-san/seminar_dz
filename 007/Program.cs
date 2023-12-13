// Напишите программу, которая принимает на вход 
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.


Console.WriteLine("Введите координаты X: ");
int numX = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y: ");
int numY = Convert.ToInt32(Console.ReadLine());

if (numX>0 && numY>0)
{
    Console.WriteLine("I");
}
else if (numX<0 && numY>0)
{
    Console.WriteLine("II");
}
else if (numX<0 && numY<0)
{
    Console.WriteLine("III");
}
else if (numX>0 && numY<0) 
{
    Console.WriteLine("IV");
}
else 
{
    Console.WriteLine("Точка находится на оси координат");
}