//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
Console.Clear();

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение диапазона: ");
int minDia = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение диапазона: ");
int maxDia = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
for (int i = 0; i <= array.Length - 1; i++) array[i] = new Random().Next(minDia, maxDia);
}

void PrintArray(int[] array)
{
Console.Write("[");
for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
Console.Write($"{array[array.Length - 1]}]");
}
