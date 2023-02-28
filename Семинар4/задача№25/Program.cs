/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */


int a, b;

Console.Write("Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);
ToDegree(a, b);

// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


