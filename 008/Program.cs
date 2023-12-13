// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.

// int [] list = {1, 2, 3, 4, 5};

// void reverseMassive(int[] list)
// {
//     int temp = 0;
//     for (int i = 0; i < list.Length/2; i++)
//     {
//         temp = list[i];
//         list[i] = list[list.Length - 1 - i];
//         list[list.Length - 1 - i] = temp;
//     }
// }

// Console.Write(reverseMassive(list));

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

// Пример использования:
int[] list = { 1, 2, 3, 4, 5 };
reverseMassive(list);

// Вывод измененного массива
Console.WriteLine(string.Join(", ", list));
