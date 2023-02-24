/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]*/

int[] array = CreateArray();

for (int i = 0; i < array.Length; i++)
    Console.Write($" {array[i]} ");
int[] CreateArray(int size = 8)
{
    int[] t_array = new int[size];
    for (int i = 0; i < size; i++)
    {
        t_array[i] = new Random().Next(0, 9);
        
    }
    return t_array;

}

