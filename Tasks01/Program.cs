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