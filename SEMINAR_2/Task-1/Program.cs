/*
Случайное число из отрезка [10, 99] и наибольшая цифра числа. Напр.: 78 -> 8, 12 -> 2
*/

// int seed = 100;
Random rand = new Random();

int number = rand.Next(10, 100);

int number1 = number/10;
int number2 = number%10;

int answer = number1 > number2 ? number1 : number2;

// int max = number1;
// if (number2 > number1) max = number2;

// где: 
// next - метод, всегда в (); диапазон указывается нижн.диапазон и верх.диапазон +1 к числу, напр. [10, 99] => (10, 99+1)
// rand - экземпляр класса Random
// Random - класс
// seed - источник времени, акутально для тестирования
// answer - тернарный оператор - оператор, использующий три операнда: условие, за которым следует знак вопроса (?), затем выражение, которое выполняется, если условие истинно, сопровождается двоеточием (:), и, наконец, выражение, которое выполняется, если условие ложно.

Console.WriteLine($"Our Random number is => {number}");
Console.WriteLine($"First number is => {number1}");
Console.WriteLine($"Second number is => {number2}");
// Console.WriteLine($"Bigger number is => {max}");

Console.WriteLine($"Bigger number is => {answer}");