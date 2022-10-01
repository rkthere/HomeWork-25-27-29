
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int SummNumb(int numb)
{
    int summ = 0;
    while (number > 0)
    {
        numb = number % 10;
        summ = summ + numb;
        number = number / 10;
    }
    return summ;
}
int summa = SummNumb(number);
Console.WriteLine($"Сумма чисел равна ->  {summa}");
