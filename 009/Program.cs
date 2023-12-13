// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.

int [] list = new int [10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(100, 1000);
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


int GetCountNumber(int[] list)
{
    int count = 0;
    for (int i = 0; i < list.Length; i++)
    {
        if (list[i]%2 == 0)
        {
            count++;
        }
    }
    return count;
}

int count = GetCountNumber(list);
Console.WriteLine($"Количество четных чисел в массиве: {count}");