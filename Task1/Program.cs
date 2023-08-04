/*Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите 2 числа, чтобы узнать какое число больше, а какое меньше ");
Console.Write("Введите 1 число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите 1 число: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Число: " + num1 + " - больше");
    Console.Write("Число: " + num2 + " - меньше");
}

else if (num1 == num2)
{
    Console.WriteLine("Число" + num1 + "равно числу" + num2);
}

else 
{
    Console.WriteLine("Число: " + num2 + " - больше");
    Console.Write("Число: " + num1 + " - меньше");
}
