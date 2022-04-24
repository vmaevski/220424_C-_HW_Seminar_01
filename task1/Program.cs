// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.
// Пример: a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

string s_a = Console.ReadLine();
int a = int.Parse(s_a);
string s_b = Console.ReadLine();
int b = int.Parse(s_b);

if (a > b)
{
    Console.Write("Max = ");
    Console.Write(a);
}
if (a < b)
{ 
    Console.Write("Max = ");
    Console.Write(b);
}
if (a == b)
{
    Console.Write("Числа равны.");
}

