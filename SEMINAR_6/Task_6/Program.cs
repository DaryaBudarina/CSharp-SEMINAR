/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int number = 2;
string GetNum(int number)
{
    string count = String.Empty;
    while(number > 0)
    {
        int result = number%2;
        count = Convert.ToString(result) + count; // Перемена мест слагаемых (к символу прибавляем накапливаемый результат).
        number = number/2;
    }
    return count;
}
Console.WriteLine($"Number {number} is {GetNum(number)}.");