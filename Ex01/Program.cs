// Напишите программу, которая на входе принимает число и выдыет его квадрат (число умноженное на часо себя).
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Write("Enter your number");
double a;
do Console.Write("a = ");
while (!double.TryParse(Console.ReadLine(), out a));
Console.Write("Ваше число в квадрате = ");
Console.Write(a * a);