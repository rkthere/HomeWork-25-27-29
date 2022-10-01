//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число(А): ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень(В): ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponent(int numA, int numB)
{
    int expo = 1;
    if (numberA > 0 && numberB > 0)
    {
        for (int i = 1; i <= numberB; i++)
        {
            expo = expo * numA;
        }
    }
    else
    {
        Console.WriteLine("Программа работает некорректно, введите числа больше 0");
    }
    return expo;
}
Console.WriteLine($"Число {numberA} в степени {numberB} -> {exponent(numberA, numberB)}");