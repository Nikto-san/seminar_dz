// Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементом массива.

// массив [2.2 0.4 9.11 7.2 78.98] => 78.58
// массив [1.22 4.5 3.33] => 3.28

double[] realNumbersArray = { 3.14, 2.718, 1.618, 4.669, 0.707 };
Console.Write(realNumbersArray);

double MinMaxDiff(double[]array)
{
    double min = array[0];
    double max = array[0];
    double diff = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        } 
        else if (array[i] > max) 
        {   max = array[i];
        }
    }
    diff = max - min;
    return diff;
}

Console.WriteLine($"=> {MinMaxDiff(realNumbersArray)}");