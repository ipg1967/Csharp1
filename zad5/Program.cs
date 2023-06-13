// Seminar 2  !!! 

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int number = new Random().Next(10, 100);

Random rand = new Random();
int randNumber = rand.Next(100, 1000); // правая граница не входит в диапазон]
System.Console.WriteLine(randNumber);
System.Console.WriteLine($"{randNumber/100}{randNumber%10}");
// или 
int Number = randNumber / 10;
// int leftNumber = randNumber / 10;
// int rightNumber = randNumber % 10;

// if (leftNumber > rightNumber)
// {
//     System.Console.WriteLine($"Левая цифра больше -> {leftNumber}");
// }
// else if (rightNumber >= leftNumber)
// {
//     System.Console.WriteLine($"Правая цифра больше -> {rightNumber}");
// }
// else
// {
//     System.Console.WriteLine("Числа равны");
// }
