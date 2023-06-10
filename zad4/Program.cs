// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// речь о целых положительных числах от 1 , если число меньше 2 - решения нет. Заранее количество циклов неизвестно. 

System.Console.WriteLine("Введите целое число :");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2) 
{
System.Console.WriteLine("число не содержит положительных четных чисел больше 1");
}
else
{
// выводим результат в требуемом по условию формате
int Nmax = number - number%2;
System.Console.Write(number + " -> ");
int index = 2;
while(index < Nmax)
{
System.Console.Write(index + ", ");
index += 2;
}    
System.Console.Write(Nmax);
}
System.Console.WriteLine("");
