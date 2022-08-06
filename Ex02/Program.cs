// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.Write("Enter number");
double a;
do Console.Write("a = ");

while (!double.TryParse(Console.ReadLine(), out a));

Console.Write("Enter number");
double b;
do Console.Write("b = ");

while (!double.TryParse(Console.ReadLine(), out b));

if(b == a * a)
{
    Console.Write("ИСТИНА");
}

else
{
    Console.Write("ЛОЖЬ");
}