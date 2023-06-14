// Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше.
// a = 5: b = 7 -> max = 7: min = 5: 
// a = 2; b = 10; -> max = 10; min = 2;
// a = -9; b = -3; -> max = -3; min = -9;

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    System.Console.WriteLine(b);
}
else 
{
    System.Console.WriteLine(a);
}