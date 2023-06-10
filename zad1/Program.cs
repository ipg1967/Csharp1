// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// судя по условию - речь только о целых числах, выберем тип int 
// знак чисел не имеет значения, величину - возьмем с запасом на 16 бит, хотя хватило бы и 8 
System.Console.WriteLine("Введите первое число: ");
int d1 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
if (d1 > Convert.ToInt16(Console.ReadLine()) )
{
    System.Console.WriteLine("max = " + d1);
}
else
{
    System.Console.WriteLine("max = " + Convert.ToInt16(Console.ReadLine()));
}
System.Console.WriteLine(""); // для красоты... 