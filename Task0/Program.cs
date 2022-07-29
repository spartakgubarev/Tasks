﻿// Почувствуй себя интерном.

//  0. Вывести квадрат числа
// Console.Clear();
// Console.Write("Введите число, возведу в квадрат: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number} в квадрате = {number*number}");

//  1. По двум заданным числам проверять является ли первое квадратом второго
// Console.Clear();
// Console.WriteLine("Введите два числа, проверю, является ли первое число квадратом второго");
// Console.Write("Ввдите первое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввдите второе число: ");
// int numberPow = Convert.ToInt32(Console.ReadLine());
// if (number*number==numberPow) Console.WriteLine ($"{numberPow} является квадратом {number}");
// else  Console.WriteLine ($"{numberPow} не является квадратом {number}");

//  2. Даны два числа. Показать большее и меньшее число
// Console.Clear();
// Console.WriteLine("Введите два числа, проверю, какое больше, а какое меньше");
// Console.Write("Ввдите первое число: ");
// int numberFirst = Convert.ToInt32(Console.ReadLine());
// Console.Write("Ввдите второе число: ");
// int numberSecond = Convert.ToInt32(Console.ReadLine());
// if (numberFirst>numberSecond) Console.WriteLine($"Число {numberSecond} меньше {numberFirst}");
// else Console.WriteLine($"Число {numberSecond} больше {numberFirst}");

//  3. По заданному номеру дня недели вывести его название
// Console.Clear();
// Console.Write("Введите день недели от 1 до 7: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number == 1) Console.WriteLine($"Вы выбрали {number} - это понедельник");
// if (number == 2) Console.WriteLine($"Вы выбрали {number} - это вторник");
// if (number == 3) Console.WriteLine($"Вы выбрали {number} - это среда");
// if (number == 4) Console.WriteLine($"Вы выбрали {number} - это четверг");
// if (number == 5) Console.WriteLine($"Вы выбрали {number} - это пятница");
// if (number == 6) Console.WriteLine($"Вы выбрали {number} - это суббота");
// if (number == 7) Console.WriteLine($"Вы выбрали {number} - это Воскресенье");
// if (number < 1 & number > 7) Console.WriteLine($"Данное значение не соответствует дню недели");

//  4. Найти максимальное из трех чисел
// Console.Clear();
// Console.WriteLine("Введите три числа: ");
// Console.Write("Число 1: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Число 2: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Число 3: ");
// int numberThree = Convert.ToInt32(Console.ReadLine());
// int max = numberOne;
// if (max < numberTwo) max = numberTwo;
// if (max < numberThree) max = numberThree;
// Console.WriteLine($"Максималное число {max}");

//  5. Написать программу вычисления значения функции y = f(a)
// Console.Clear();
// Console.WriteLine("Задан функция y=f(a)");
// Console.Write("Ввведите значение а=");
// int a = Convert.ToInt32(Console.ReadLine());
// int y = a;
// Console.WriteLine($"y={y}");

//  6. Выяснить является ли число чётным
// Console.Clear();
// Console.Write("Введите число, проверю на четность: ");
// int evenNumber = Convert.ToInt32(Console.ReadLine());
// if (evenNumber % 2 == 0) Console.WriteLine($"Число {evenNumber} четное");
// else Console.WriteLine($"Число {evenNumber} нечетное");

//  7. Показать числа от -N до N
// Console.Clear();
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = -n; i <= n; i++)
// {
//     Console.Write($"{i} ");
// }

//  8. Показать четные числа от 1 до N
// Console.Clear();
// Console.Write("Введите число N, покажу вче четные от 1 до N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write(1 + " ");
// for (int i = 2; i <= n; i += 2) Console.Write($"{i} ");

//  9. Показать последнюю цифру трёхзначного числа
// Console.Clear();
// Console.Write("Введите трехзначное число, покажу последнюю цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number % 10}");

// 10. Показать вторую цифру трёхзначного числа
// Console.Clear();
// Console.Write("Введите трехзначное число, покажу вторую цифру: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number % 100 / 10}");

// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// Console.Clear();
// int number = new Random().Next(10, 100);
// int numberFirst = number / 10;
// int numberSecond = number % 10;
// int max = Math.Max(numberFirst, numberSecond);
// Console.WriteLine($"В числе {number}, наибольшее число {max}");

// 12. Удалить вторую цифру трёхзначного числа
// Console.Clear();
// string numberRnd = string.Empty + new Random().Next(100, 1000);
// Console.WriteLine(numberRnd);
// Console.WriteLine($"{numberRnd.Remove(1, 1)}");

// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// Console.Clear();
// int numberRnd = new Random().Next(100, 1000);
// Console.Write($"Задан число {numberRnd}. Введите число, я проверю его на кратность: ");
// int multiplicity = Convert.ToInt32(Console.ReadLine());
// if (numberRnd % multiplicity == 0) Console.WriteLine($"Числа кратны {numberRnd} / {multiplicity} = {numberRnd / multiplicity}");
// else Console.WriteLine($"Числа не кратны {numberRnd} / {multiplicity} остаток {numberRnd % multiplicity}");


// 14. Найти третью цифру числа или сообщить, что её нет


// Треугольник Паскаля *** от Сергея Каменского ***
// Console.Clear();
// int row = 20;
// int[,] triagle = new int[row, row];
// const int cellWidth = 6;

// void FillTriagle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         triagle[i, 0] = 1;
//         triagle[i, i] = 1;
//     }

//     for (int i = 2; i < row; i++)
//     {
//         for (int j = 1; j <= i; j++)
//         {
//             triagle[i, j] =
//                 triagle[i - 1, j - 1] + triagle[i - 1, j];
//         }
//     }
// }

// void PrintTriagle()
// {
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < row; j++)
//         {
//             if (triagle[i, j] != 0)
//                 Console.Write($"{triagle[i, j],cellWidth}");
//         }
//         Console.WriteLine();
//     }
// }
// void Magic()
// {
//     int col = cellWidth * row;
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j <= i; j++)
//         {
//             Console.SetCursorPosition(col, i + 1);
//             if (triagle[i,j]!=0) Console.Write($"{triagle[i,j],cellWidth}");
//             // if (triagle[i, j] != 0) Console.WriteLine("*");
//             col += cellWidth * 2;
//         }
//         col = cellWidth * row - cellWidth * (i + 1);
//         Console.WriteLine();
//     }
// }

// Console.ReadLine();
// FillTriagle();
// PrintTriagle();
// Console.ReadLine();
// Magic();