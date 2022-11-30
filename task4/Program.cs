// Задача №4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

Console.WriteLine ("Введите число");
string number = Console.ReadLine ()!;
int N = int.Parse (number);

if (N < 0)
{
    N = N*(-1);
    Console.WriteLine("Вы ввели отричательное чило, число переведено в положительное");
}

for (int i = 2; i <= N; i = i + 2)
{
    Console.WriteLine(i);
}

//Альтернативный вариант записи цикла for:

/*for (int i = 1; i <=N; i++)
{
    if (i%2 == 0)
    {
        Console.WriteLine (i);
    }
}
*/
