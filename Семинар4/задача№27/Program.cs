/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/




int a;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
ToDegree(a);

// Функция 
void ToDegree(int a)
{
    int result = 0;
    while (a > 0)
    {
        result += a % 10;
        a = a / 10;
    }

    

    Console.WriteLine(result);
}



