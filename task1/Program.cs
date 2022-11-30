//Задача №1: Напишите программу, которая примет на вход два числа и выведет,какое число больше, какое меньше.

Console.WriteLine ("Введите первое число");
string number1 = Console.ReadLine ()!;
int num1 = int.Parse (number1);

Console.WriteLine ("Введите второе число");
string number2 = Console.ReadLine ()!;
int num2 = int.Parse (number2);

if (num1 > num2)
{
    Console.WriteLine ("Первое число больше второго");
}
if (num2 > num1)
{
    Console.WriteLine ("Второе число больше первого");
}
if (num1 == num2)
{
    Console.WriteLine ("Числа равны");
}