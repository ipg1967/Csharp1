//
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите первое число - ");
int fnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число - ");
int snumber = Convert.ToInt32(Console.ReadLine());
if (snumber*snumber == fnumber || fnumber*fnumber == snumber) 
    {
    System.Console.WriteLine($"Число {fnumber} является кратным квадрату числа {snumber} или наоборот");
    }
else
    {
    System.Console.Write("Числа не кратны квадратам ");
    }