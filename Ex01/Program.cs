Console.Write("Enter your number");
double a;
do Console.Write("a = ");
while (!double.TryParse(Console.ReadLine(), out a));
Console.Write("Ваше число в квадрате = ");
Console.Write(a * a);