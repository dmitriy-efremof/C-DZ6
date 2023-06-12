// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите размер массива: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int [] numbers = new int[num];
// int sum = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine("Введите {0}-й элемент", i + 1);
//     numbers[i] = Convert.ToInt32(Console.ReadLine());
// }
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     sum++;
// }

// Console.Write("[");
// Console.Write(String.Join(";", numbers));
// Console.Write("]");
// Console.WriteLine();
// Console.Write($"Количество чисел больше 0: {sum}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение b1:");
// int b1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k1:");
// int k1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2:");
// int b2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k2:");
// int k2 = Convert.ToInt32(Console.ReadLine());

// double x = -(b1 - b2) / (k1 - k2);
// double y = k1 * x + b1;

// Console.WriteLine($"Точка пересечения двух прямых: ({x}:{y})");
