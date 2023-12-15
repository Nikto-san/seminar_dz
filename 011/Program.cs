// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

// массив [10 21 14 93 23] => 2

int [] list = new int [10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}
FillArray(list);

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}
PrintArray(list);

int GetAmountNumbers (int [] array)
{
    int count = 0;
    int minValue = 20;
    int maxValue = 90;
    for (int i = 0; i < array.Length; i++)
    {
        if((array[i] >= 20)&&(array[i]<=90))
        {
            count++;
        }
    }
    return count;    
}

Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90] = " + GetAmountNumbers(list));