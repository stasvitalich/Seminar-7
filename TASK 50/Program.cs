// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Размерность массива: количество строк.
int n = 0;

//Размерность массива: количество столбцов. 
int m = 0;

Console.Write("Введите количество столбцов (M): ");
// Пишем структуру, которая защитит нашу программу от поломки
// в случае ввода пользователем строки, а не числа.
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

// Задаём двумерный массив.
int[,] array = new int[n, m];

// Заполняем его рандомными числами.
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}

// Выводим массив на печать.
Console.WriteLine("");
Console.WriteLine("Инициирован двумерный массив: ");
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}

// Инициируем ввод позиции элемента, который мы хотим вывести на экран.
// Если такой позиции в массиве нет, то пишем об этом.
Console.WriteLine("");
Console.WriteLine("Введите позиции элемента в двумерном массиве");
Console.WriteLine("Введите позицию M");
int сolumnNumberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию N");
int lineNumberN = int.Parse(Console.ReadLine());

// Так как нумерация столбцов и строк начинается с 0,
// то позиция найдётся, 
// если искомые переменные будут строго меньше количества столбцов и строк. 
if (сolumnNumberM < m && lineNumberN < n)
{
    Console.WriteLine($"На данной позиции находится элемент {array[lineNumberN, сolumnNumberM]}");
}  
else
{
    Console.WriteLine("В массиве нет такой позиции.");
}
