// . Напишите программу вычисления модуля числа.
// 2 -> 2
// -3 -> 3
// -7 -> 7

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a < 0)
{
    a = -a;
}
Console.WriteLine(a);