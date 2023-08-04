/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число и я скажу, является ли оно чётным");
Console.Write("Введите любое число: ");

int num = int.Parse(Console.ReadLine());
int remain = num % 2;

if (remain == 0)
{
    Console.WriteLine("Число: " + num + " - четное");
}
else 
{
    Console.WriteLine("Число: " + num + " - не четное");
}
