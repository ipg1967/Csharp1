// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// знак чисел не имеет значения, величину - возьмем с запасом на 16 бит, хотя хватило бы и 8 . Проверять не будем. 

System.Console.WriteLine("Введите первое число: ");
int d1 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
int d2 = Convert.ToInt16(Console.ReadLine());
System.Console.WriteLine("Введите третье число: ");
int d3 = Convert.ToInt16(Console.ReadLine());

int max = d3;

if(max > d1)
{
    if(max < d2)
    { 
        max = d2;
    }
}
else
{
    if(d1 > d2)
    {   
        max = d1;
    }
    else
    { 
    max = d2;
    }
}

System.Console.WriteLine(d1 + ", " + d2 + ", " + d3 + " -> " + max);


System.Console.WriteLine(""); // для отделения визуально в терминале 