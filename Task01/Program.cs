// Напишите программу, которая 
// принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine ("Введите первое целое число ");
int num_1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе целое число ");
int num_2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите третье целое число ");
int num_3 = Convert.ToInt32 (Console.ReadLine ());
int max = num_1;

if (num_2 > max) 
{
    max = num_2;
}
else if (num_3 > max);
{
    max = num_3;
}
Console.WriteLine ($"Максимальное число {max}");