// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int [] list = new int [10];

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
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
Console.Write(list);

void reverseMassive(int[] list)
{
    int temp = 0;
    for (int i = 0; i < list.Length / 2; i++)
    {
        temp = list[i];
        list[i] = list[list.Length - 1 - i];
        list[list.Length - 1 - i] = temp;
    }
}
reverseMassive(list);
PrintArray(list);