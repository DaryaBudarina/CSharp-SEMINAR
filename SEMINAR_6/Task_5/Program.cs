/*
Задача 40: Напишите программу, которая принимает 
на вход три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона 
треугольника меньше суммы двух других сторон.
*/

int RandomNum()
{
    Random rand = new Random();
    int randomNum = rand.Next(1, 20);
    return randomNum;
}

int a = RandomNum(), b = RandomNum(), c = RandomNum();

bool CheckTriangle(int a, int b, int c)
{
    if((a < (b + c)) && (b < (a + c)) && (c < (a + b)))
    {
        return true;
    }
    return false;
}

Console.WriteLine($"Triangle from {a}, {b}, {c} is {CheckTriangle(a, b, c)}.");