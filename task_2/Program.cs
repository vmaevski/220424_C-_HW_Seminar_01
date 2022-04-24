// *. Напишите программу, которая на вход принимает значение, а
// на выходе показывает обратное значение.
// 1 -> 1
// 2 -> 0.5
// 0.25 -> 4

string s_a = Console.ReadLine();
double a = double.Parse(s_a);

a = 1 / a;

Console.WriteLine(a);