Console.Clear();
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] Array = new int[20];
// Random rand = new Random();
// int count = 0;

// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = rand.Next(100, 1000);
//     Console.Write($"{Array[i]}, ");

//     if (Array[i] % 2 == 0)
//     {
//         count += 1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"В данном массиве имеется {count} четных чисел");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// int[] Array = new int[12];
// Random rand = new Random();
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = rand.Next(-100, 100);
//     Console.Write($"{Array[i]}, ");
// }
// int sum = 0;
// for (int i = 1; i < Array.Length; i += 2)
// {
//     sum = sum + Array[i];
// }
// Console.WriteLine($"Суммa элементов, стоящих на нечётных позициях: {sum}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] Array = new int[6];
// Random rand = new Random();
// for (int i = 0; i < Array.Length; i++)
// {
//     Array[i] = rand.Next(-100, 100);
//     Console.Write($"{Array[i]}, ");
// }
// int min = Array[0];
// int max = Array[0];
// for (int i = 1; i < Array.Length; i++)
// {
//     if (Array[i] > max)
//     {
//         max = Array[i];
//     }
//     if (Array[i] < min)
//     {
//         min = Array[i];
//     }
// }
// Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {max - min}");


//Вариант2 - иная функция вызова массива
// int[] FillArray(int[] array, int min, int max)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(min, max + 1);
//     }
//     return array;
// }
// int[] array = new int[8];
// FillArray(array, -10, 10);
// Console.WriteLine($"[{String.Join(", ", array)}]");
// int min = array[0];
// int max = array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] > max)
//     {
//         max = array[i];
//     }
//     else if (array[i] < min)
//     {
//         min = array[i];
//     }
// }
// Console.Write($"Разница между максимальным и минимальным элементом массива равна {max - min}");
