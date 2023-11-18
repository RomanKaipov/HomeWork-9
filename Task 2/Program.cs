// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number;
    number = int.Parse(a);
    return number;
}

int GetSum(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber)
    {
        return firstNumber;
    }
    else
    {
       return firstNumber + GetSum(firstNumber + 1, secondNumber);
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
        Console.Write($"Сумма элементов в промежутке от {firstNumber} до {secondNumber} = {GetSum(firstNumber, secondNumber)}");
    }
    else
    {
        Console.Write($"Сумма элементов в промежутке от {secondNumber} до {firstNumber} = {GetSum(secondNumber, firstNumber)}");
    }
}



