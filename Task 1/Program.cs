// Задача 64: Задайте значения M и N. 
// Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number;
    number = int.Parse(a);
    return number;
}

void PrintNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber % 2 == 0)
    {
        Console.Write(firstNumber + " ");
    }
    if (firstNumber == secondNumber)
    {
        return;
    }
    else
    {
        PrintNumbers(firstNumber + 1, secondNumber);
    }
}

bool CheckNumbers(int firstNumber, int secondNumber)
{
    if (firstNumber >= 0 && secondNumber >= 0)
    {
        return true;
    }
    else
    {    
        Console.WriteLine("Введенные числа не все натуральны");
        return false;
    }
}

int firstNumber = ReadInt("Введите первое число");
int secondNumber = ReadInt("Введите второе число");

if (CheckNumbers(firstNumber, secondNumber))
{
    if (secondNumber > firstNumber)
    {
        Console.Write($"Чётные натуральные числа в промежутке от {firstNumber} до {secondNumber}: ");
        PrintNumbers(firstNumber, secondNumber);
    }
    else 
    {
        Console.Write($"Чётные натуральные числа в промежутке от {secondNumber} до {firstNumber}: ");
        PrintNumbers(secondNumber, firstNumber);
    }
}
