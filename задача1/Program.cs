// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  Использовать рекурсию, не использовать циклы.


Console.Write("Введите  число n : ");
Console.WriteLine();
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  число m : ");

int number1 = Convert.ToInt32(Console.ReadLine());
void GetNumbers(int num1, int num)
{
    if (num1 <= num)
    {
        Console.Write(num1 + " ");
        GetNumbers(num1 + 1, num);

    }
    else
        Console.Write("значение M должно быть меньше N! ");
}

GetNumbers(number1, number);