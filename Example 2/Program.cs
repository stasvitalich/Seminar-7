// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

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
// в случае ввода пользователем строки, а не числа
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

// Пишем метод, который будет заоплнять наш массив согласно условию.
// Задаём двумерный массив.
// Заполняем массив по формуле из задачи,
// где каждый элемент находится по формуле Aₘₙ = m+n.
int[,] GetArray(int n, int m)
{
    int[,] array = new int[n, m];
    for (int i = 0; i < n; i = i + 1)
    {
        for (int j = 0; j < m; j = j + 1)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

// Выводим метод на печать.
int[,] resultArray = GetArray(n, m);
for (int i = 0; i < n; i = i + 1)
{
    for (int j = 0; j < m; j = j + 1)
    {
        Console.Write(resultArray[i, j] + " ");
    }
    Console.WriteLine("");
}

