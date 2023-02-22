// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void NumberToArray(int number, int[] array)
{
    while (number > 0)
    {
        int digit = number % 10;
        array[number.ToString().Length - 1] = digit;
        number /= 10;       
    }
}

Console.Write("Enter ammount: ");
int a = int.Parse(Console.ReadLine()!);
int[] array = new int[a.ToString().Length];
NumberToArray(a, array);

int sum = 0;

for (int i=0; i < a.ToString().Length; i++)
{
    sum = sum + array[i];
}

Console.WriteLine("The sum of numbers in ammount is: " + sum);