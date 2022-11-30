// Задача №2: Напишите программу, которая на вход принимает три числа и выводит максимальное.

Console.WriteLine ("Введите первое число");
string number1 = Console.ReadLine ()!;
int num1 = int.Parse (number1);

Console.WriteLine ("Введите второе число");
string number2 = Console.ReadLine ()!;
int num2 = int.Parse (number2);

Console.WriteLine ("Введите третье число");
string number3 = Console.ReadLine ()!;
int num3 = int.Parse (number3);

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}
Console.WriteLine("max= ");
Console.Write(max);