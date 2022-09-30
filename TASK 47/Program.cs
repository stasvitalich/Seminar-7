﻿// Задача 47.
// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//Размерность массива: количество строк.
int n = 0;

//Размерность массива: количество столбцов. 
int m = 0;

Console.Write("Введите количество столбцов (M): ");

// Пишем структуру, которая защитит нашу программу от поломки
// в случае ввода пользователем строки, а не числа
bool parseMIsOk = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseMIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    m = numberM;
}

Console.Write("Введите количество строк (N): ");

// Пишем структуру, которая защитит нашу программу от поломки
// в случае ввода пользователем строки, а не числа.
bool parseNIsOk = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseNIsOk)
{
    Console.WriteLine("Введено значение некорректного формата");
    return;
}
else
{
    n = numberN;
}

// Задаём двумерный массив,
// который будем заполнять вещественными числами. 
double[,] array = new double[n, m];

// Заполняем его рандомными числами. Для этого создаём переменную random.
Random random = new Random();
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        array[i, j] = random.NextDouble() * 10; // Пусть рандомные числа будут < 10.  
    }
}

// Выводим массив на печать.
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        Console.Write(array[i, j].ToString("f1") + " "); // Обойдём ограничение по округлению,
    }                                                    // оставив 1 знака после точки.
    Console.WriteLine("");
}
