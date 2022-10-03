// Задача 8: Напишите программу, которая 
// на вход принимает число (N), а 
// на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число ");
int num_1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine($"Все чётные числа от 1 до {num_1} ");
int count = 2;
if (num_1 == 1)
{
Console.WriteLine($"Ошибка! Число равно 1.");
}
else if (num_1 > 1)    


while (count <= num_1)
{
    Console.Write ($"{count} ");
    count = count + 2;
}