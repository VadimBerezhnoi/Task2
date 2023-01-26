//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите число A ");
Console.WriteLine("Введите число B ");
Console.WriteLine("Введите число C ");

int numA = int.Parse(Console.ReadLine()!);
int numB = int.Parse(Console.ReadLine()!);
int numC = int.Parse(Console.ReadLine()!);

if (numA > numB && numA > numC)
{
  Console.WriteLine($"{numA} максимальное число");
}

else if (numB > numA && numB > numC)
{
    Console.WriteLine($"{numB} максимальное число");
}

else if (numC > numA && numC > numB)
{
    Console.WriteLine($"{numC} максимальное число");
}