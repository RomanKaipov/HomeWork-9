// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string a = Console.ReadLine();
    int number;
    number = int.Parse(a);
    return number;
}

int AckermannFunction(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (secondNumber == 0)
    {
        return AckermannFunction(firstNumber - 1, 1);
    }
    else
    {
        return AckermannFunction(firstNumber - 1, AckermannFunction(firstNumber, secondNumber - 1));
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
Console.Write(AckermannFunction(firstNumber, secondNumber));
}