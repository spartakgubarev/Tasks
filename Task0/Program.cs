// Почувствуй себя интерном.

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
//  5. Написать программу вычисления значения функции y = f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет


// Треугольник Паскаля *** от Сергея Каменского
// Console.Clear();
// int row = 10;
// int[,] triagle = new int[row, row];
// const int cellWidth = 5;

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
//             // if (triagle[i,j]!=0) Console.Write($"{triagle[i,j],cellWidth}");
//             if (triagle[i, j] != 0) Console.WriteLine("*");
//             col += cellWidth * 2;
//         }
//         col = cellWidth * row - cellWidth * (i + 1);
//         Console.WriteLine();
//     }
// }

// Console.ReadLine();
// FillTriagle();
// // PrintTriagle();
// Console.ReadLine();
// Magic();