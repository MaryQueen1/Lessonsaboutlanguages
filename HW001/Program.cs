// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int value1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int value2 = Convert.ToInt32(Console.ReadLine());

if (value1 >= value2)
{
    int max = value1;
    int min = value2;

    Console.Write("max = ");
    Console.Write(max);
    Console.Write(" min = ");
    Console.Write(min);
}

else if (value1 <= value2)
{
    int max = value2;
    int min = value1;
    
    Console.Write("max = ");
    Console.Write(max);
    Console.Write(" min = ");
    Console.Write(min);
}
