Console.Write("Введите число 1 ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2 ");
int a2 = Convert.ToInt32(Console.ReadLine());
if(a1 == a2 * a2)
{
    Console.Write($"Yes");
}
else
{
    Console.WriteLine($"No");
}