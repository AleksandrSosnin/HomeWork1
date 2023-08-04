/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите 3 числа, чтобы узнать какое из чисел максимальное");
Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 2 число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите 3 число: ");
int num3 = int.Parse(Console.ReadLine());

int MaxNum = num1;

if(num1 > MaxNum ) MaxNum = num1;
if(num2 > MaxNum ) MaxNum = num2;
if(num3 > MaxNum ) MaxNum = num3;

Console.Write( + MaxNum + " - максимальное");
