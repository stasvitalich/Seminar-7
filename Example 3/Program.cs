// Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные. 
// Замените эти элементы на их квадраты. 

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
// Заполняем массив по формуле из задачи.
// Если индекс элемента чётен по строке и по столбцу,
// меняем этот элемент на его квадрат.
int[,] GetArray(int n, int m)
{
    // Заполняем массив
    int[,] array = new int[n, m];

    for (int i = 0; i < n; i = i + 1)
    {
        for (int j = 0; j < m; j = j + 1)
        {
            array[i, j] = new Random().Next(1, 5);
        }
    }
    
    // Выводим квадраты элементов, если оба индекса чётные
    for (int i = 0; i < n; i = i + 1)
    {
        for (int j = 0; j < m; j = j + 1)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                array[i, j] = array[i, j] * array[i, j];
            }
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