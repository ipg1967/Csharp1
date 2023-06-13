// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

System.Console.WriteLine("Введите первое число - ");
int fnumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число - ");
int snumber = Convert.ToInt32(Console.ReadLine());
if (fnumber%snumber == 0)
{
    System.Console.WriteLine("Число является кратным");
}
else
{
    System.Console.Write("Число не кратно, остаток ");
    System.Console.WriteLine(fnumber%snumber );
}