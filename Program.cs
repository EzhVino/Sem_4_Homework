//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Deg(int num1, int num2)
{
    int degree = Convert.ToInt32(Math.Pow(num1, num2));
    return degree;
}

Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a + " в степени " + b + " -> " + Deg(a, b));

// ИЛИ

void Deg(int num1, int num2)
{
    int degree = Convert.ToInt32(Math.Pow(num1, num2));
    Console.WriteLine(num1 + " в степени " + num2 + " -> " + degree);
}

Console.WriteLine("Input number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B: ");
int b = Convert.ToInt32(Console.ReadLine());
Deg(a, b);

// * Все еще не понимаю, где же использовать void  а где с типом данных. И то и то работает


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumOfDigits(int num)
{
    int sum = 0;
    while (num % 10 > 0)
    {
        int currentdigit = num % 10;
        sum += currentdigit;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("-> " + SumOfDigits(number));


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] Arrayof8 (int min, int max)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}

Console.WriteLine("Задайте диапазон чисел в массиве от минимального:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("до максимального:");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = Arrayof8 (min, max);
ShowArray(myArray);
