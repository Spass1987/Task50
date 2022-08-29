// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет.

int m = 3;
int n = 4;
Console.Write("Введите номер строки: ");
int h = Convert.ToInt16(Console.ReadLine());
Console.Write("А теперь номер столбца: ");
int w = Convert.ToInt16(Console.ReadLine());


int[,] array = new int[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i,j] = new Random().Next(0, 10);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine("");
}

if (h <= m && w <= n){  // Пользователь не обязан считать как программист, поэтому считаем с единицы
    Console.WriteLine($"Вот что я нашел: {array[h-1,w-1]}");
}
else {
    Console.WriteLine($"{h} {w} -> в данном массиве нет таких координат");
}