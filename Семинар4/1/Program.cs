
int TakeConsoleInt(string str = "Введите число: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}

int a = TakeConsoleInt();
int Fact(int a)
{
    int n = 1;
    for (int i = 1; i <= a; i++)
          n *= i;
     
    return n;
}    
Console.Write($"{a} -> {Fact(a)}");