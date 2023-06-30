/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму 
отрицательных и положительных элементов массива.Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

Console.Clear();

int [] CreatArray(int size, int min, int max)
{
    int [] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max+1);
    }
    return array;
}

string Print(int [] array)
{
    return string.Join(", ", array);
}

(int sumNegName, int sumPosName) FindNegPos(int [] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    foreach (int el in array)
    // foreach - цикл для перебора значений коллекции   
    // var - для обозначения неизвестного элемента коллекции (строки, значения или пр.)
    // item/el - элемент(переменная) коллекции
    {
        sumPos += el > 0 ? el:0;    // тернарный оператор - работает сразу с тремя операндами, в зависимости от результата условия, которое задано в первом операнде, возвращает значение второго(если первый - true), или третьего(если первый - false) операнда
        sumNeg += el < 0 ? el:0;
    }

    return (sumNegName: sumNeg, sumPosName: sumPos); // кортеж - возвращение нескольких элементов
}

int [] array = CreatArray(12, -9, 9);
Console.WriteLine($"Out array is [{Print(array)}]");

var tuple = FindNegPos(array);
Console.WriteLine($"Sum negative is {tuple.sumNegName} and Sum positive is {tuple.sumPosName}");