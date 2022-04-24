// Задача 2: Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел
// Пример:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
string s_b = Console.ReadLine();
int b = int.Parse(s_b);
string s_c = Console.ReadLine();
int c = int.Parse(s_c);

if (a<b)
{
    a=b;
}
if (a<c)
{
    a=c;
}
Console.Write("-> ");
Console.WriteLine(a);