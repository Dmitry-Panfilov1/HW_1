// Задача №3: Напишите прграмму, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка).

Console.WriteLine ("Введите число");
string number = Console.ReadLine ()!;
int num = int.Parse (number);

 if (num%2 == 0)
 {
    Console.WriteLine("введенное число - четное");
 }
 else
 {
    Console.WriteLine("Введенное число - нечетное");
 }