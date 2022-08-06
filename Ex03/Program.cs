// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Enter your number 1-7");
int a;
do Console.Write(" (a) = ");
while (!int.TryParse(Console.ReadLine(), out a));

if(a == 1)
{
    Console.Write("Monday");
}

else if(a == 2)
{
    Console.Write("Tuesday");
}

else if(a == 3)
{
    Console.Write("Wednesday");
}

else if(a == 4)
{
    Console.Write("Thurday");
}

else if(a == 5)
{
    Console.Write("Friday");
}

else if(a == 6)
{
    Console.Write("Saturday");
}

else if(a == 7)
{
    Console.Write("Sunday");
}

else
{
    Console.WriteLine("Введите целое число от 1 до 7");
}

// Придумать, как можно сделать так, чтобы 1, 1+7, 1+7+7 = Monday и др.. Т.е. не только ввод чисел от 1-7