// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// Пример:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

int result = 0;

while (result < (a - 1))
{
    result += 2;
    Console.Write($"{result} ");
}