// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
// Пример:
// 4 -> да
// -3 -> нет
// 7 -> нет

string s_a = Console.ReadLine();
int a = int.Parse(s_a);

if (a % 2 == 0)
{
    Console.WriteLine("Число Чётное");
}
else
{
    Console.WriteLine("Число НЕчётное");
}