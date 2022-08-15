// ## Почувствуй себя джуном*

// 15. Дано число. Проверить кратно ли оно 7 и 23
// Console.Clear();
// Console.Write ("Введите число, проверю на кратность 7 и 23: ");
// int number = Kratnost ();
// int Kratnost ()
// {
//     int numberKratost = Convert.ToInt32(Console.ReadLine());
//     if (numberKratost%7==0 && numberKratost%23==0) Console.Write($"\nЧисло {numberKratost} кратно 7 и 23.");
//     else Console.Write($"\nЧисло {numberKratost} не кратно 7 и 23.");
//     return numberKratost;
// }
// Console.Write($"\nPress any key to exit.\n");
// Console.ReadKey();

// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным
// Console.Clear();
// int numberWeek = RandomWeek();
// int RandomWeek ()
// {
//     return new Random().Next(1,8);
// }
// if (numberWeek==6 ^ numberWeek==7) Console.Write($"{numberWeek} - это выходной\n");
// else Console.Write($"{numberWeek} - это будни\n");
// Console.Write($"\nPress any key to exit.\n");
// Console.ReadKey();

// 17. По двум заданным числам проверять является ли одно квадратом другого
// Console.Clear();
// Console.Write("Введите два числа, проверю, является одно, квадратом другого:\n");
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// FindPow(firstNumber, secondNumber);
// void FindPow (int a, int b)
// {
//     if (a==b*b ^ b==a*a) Console.WriteLine ("одно число является квадратом другого");
//     else Console.WriteLine("ни одно число не является квадратом другого");
// }
// Console.Write($"\nPress any key to exit.\n");
// Console.ReadKey();




// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y



// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У,
// причем X ≠ 0 и Y ≠ 0
// Console.Clear();
// int x = RandomNumber();
// int y = RandomNumber();
// int RandomNumber()
// {
//     int rnd = new Random().Next(-1,2);
//     if (rnd==0) return RandomNumber();
//     return rnd;
// }
// Console.WriteLine(x);
// Console.WriteLine(y);
// FindCircle(x,y);
// void FindCircle (int x, int y)
// {
//     if (x>0 & y >0) Console.WriteLine ($"первая четверть");
//     if (x<0 & y >0) Console.WriteLine ($"вторая четверть");
//     if (x<0 & y <0) Console.WriteLine ($"третья четверть");
//     if (x>0 & y <0) Console.WriteLine ($"четвертая четверть");
// }
// Console.Write($"\nPress any key to exit.\n");
// Console.ReadKey();

// 20. Задать номер четверти, показать диапазоны для возможных координат
// Console.Clear();
// int quarterNumber = new Random().Next(1,5);
// SizeQuarter(quarterNumber);
// void SizeQuarter(int x)
// {
//     if (x==1) Console.Write($"{x} - четверть принадлежит x(0;+oo) U y(0;+oo)");
//     if (x==2) Console.Write($"{x} - четверть принадлежит x(-oo;0) U y(0;+oo)");
//     if (x==3) Console.Write($"{x} - четверть принадлежит x(-oo;0) U y(-oo;0)");
//     if (x==4) Console.Write($"{x} - четверть принадлежит x(0;+oo) U y(-oo;0)");
// }
// Console.Write($"\nPress any key to exit.\n");
// Console.ReadKey();

// 21. Программа проверяет пятизначное число на палиндромом.
// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// string number=Console.ReadLine();
// ProverkaNumber (number);
// void ProverkaNumber(string number)
// {
//     for (int i=0; i<number.lenght;i++)
//     {
//         Console.WriteLine(number[i]);
//     }
// }

// Console.Write($"\nPress any key to exit\n");
// Console.ReadKey();

// 22. Найти расстояние между точками в пространстве 2D/3D
// Random rand = new Random();
//             int n = 5;
//             char[,] a = new char[5, 5];
//             for(int i = 0; i < n; i++)
//             {
//                 for (int j = 0; j < n; j++)
//                 {
//                     a[i, j] = (char)rand.Next(0x0410, 0x44F);
//                     Console.Write(a[i, j] + " ");
//                 }                             
//                 Console.WriteLine();
//             }
//             Console.ReadKey(true);

// рандомные символы
// for (int j = 0; j < 10; j++)
// {
//     for (int i = 0; i < new Random().Next(1, 6); i++)
//     {
//         Console.Write($"{(char)new Random().Next(33, 127)}");
//     }
//     Console.WriteLine();
// }


// таблица уномжнеия
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, n];

// for (int i = 0; i < n; i++)
// {
//     for (int j = i; j < n; j++)
//     {
//         matrix[i, j] = (1 + i) * (1 + j);
//         matrix[j, i] = matrix[i, j];
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Сортировка
/*
[6, 15, 2, 9, -3]
MIN = 6
6 , 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
*/
// Console.Clear();
// Random rnd = new Random();
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = rnd.Next(-20, 21);
// }
// Console.Write("[" + string.Join(",\t", array) + "]");
// Console.WriteLine();

// int temp = 0;
// for (int i = 0; i < n - 1; i++)
// {
//     int min = array[i];
//     for (int j = i + 1; j < n; j++)
//     {
//         if (min > array[j])
//         {
//             min = array[j];
//             temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//     }

// }
// Console.Write("[" + string.Join(",\t", array) + "]");

// Буткемп. 4 урок. Программирование
// Console.Clear();
// int n = 5;
// string[] array = new string[n];
// for (int i = 0; i < n; i++)
// {
//     array[i] = Console.ReadLine(); //
// }
// Console.Write("[" + string.Join(", ", array) + "]");
// Console.WriteLine();

// string temp = string.Empty;
// for (int i = 0; i < n - 1; i++)
// {
//     string min = array[i];
//     for (int j = i + 1; j < n; j++)
//     {
//         if (min.Length > array[j].Length)
//         {
//             min = array[j];
//             temp = array[i];
//             array[i] = array[j];
//             array[j] = temp;
//         }
//     }

// }
// Console.Write("[" + string.Join(",", array) + "]");

// Сдивг массива на определенное число
// Console.Clear();
// Console.Write("Введите длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] arrayNew = new int[n];
// CreateRandomArray(array);
// void CreateRandomArray(int[] array) // функция заполнения рандомно массива
// {
//     Random rnd = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         array[i] = rnd.Next(11);
//     }
//     Console.Write($"Первоначальный массив: [{string.Join(", ", array)}]");
// }
// Console.Write("\nВведите на сколько нужно сместить массив влево или вправо: ");
// int step = Convert.ToInt32(Console.ReadLine());
// ShiftArrayNew(array, arrayNew);
// void ShiftArrayNew(int[] array, int[] arrayNew) // функция сдига массива влево, вправо
// {
//     if (step >= 0)
//     {
//         step--;
//         for (int i = 0; i < n - step; i++) arrayNew[i] = array[i + step];
//         int b = 0;
//         for (int i = n - step; i < n; i++) arrayNew[i] = array[b++];
//     }
//     else
//     {
//         // step++;
//         for (int i = 0; i < -step; i++) arrayNew[i] = array[n + step + i];
//         int b = 0;
//         for (int i = -step; i < n; i++) arrayNew[i] = array[b++];
//     }
//     Console.Write($"Первоначальный массив: [{string.Join(", ", arrayNew)}]");
// }
// Console.ReadKey();

/*
Сортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
*/
// Console.Clear();
// Console.Write("Ввведите количество массива: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[number];
// CreateRandomArray(array);
// void CreateRandomArray(int[] array)
// {
//     Random rnd = new Random();
//     for (int i = 0; i < number; i++)
//     {
//         array[i] = rnd.Next(11);
//     }
//     Console.Write("Начальный массив:\t[" + string.Join(", ", array) + "]");
// }
// SortingArray(array);
// void SortingArray(int[] array)
// {
//     int temp;
//     for (int i = 0; i < number; i++)
//     {
//         for (int j = 0; j < number - 1; j++)
//         {
//             if (array[j] > array[j + 1])
//             {
//                 temp = array[j];
//                 array[j] = array[j + 1];
//                 array[j + 1] = temp;
//             }
//         }
//     }
//     Console.Write("\nКонечный массив:\t[" + string.Join(", ", array) + "]");
// }
// Console.ReadKey();
