/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8

List<int> list = new List<int>(); // Для создания коллекции (вместо массива, чтобы не определять заранее размер).

Console.WriteLine(string.Join(", ", list));
List.Add(6);
Console.WriteLine(string.Join(", ", list));
List.Add(8);
Console.WriteLine(string.Join(", ", list));

Console.WriteLine(list.Count); // Вернет размер списка.
*/

List<int> GetFibonacci(int number)
{
    List<int> list = new List<int>();
    list.Add(0);
    list.Add(1);
    for (int i = 0; i < number - 2 ; i++)
    {
       list.Add((list[list.Count - 1]) + (list[list.Count - 2])); 
    }
    return list;
}
Console.WriteLine($"Ряд чисел Фибоначчи {string.Join(", ", GetFibonacci(5))}");