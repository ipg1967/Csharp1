// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// возьмем диапазон числе а запасом на 32 бита, для проверки переведем число в модуль  
System.Console.WriteLine("Введите число для проверки делимости на 2: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (number%2 > 0)
{
System.Console.WriteLine(number + " -> нет"); 
}
else
{
    System.Console.WriteLine(number + " -> да"); 
}
