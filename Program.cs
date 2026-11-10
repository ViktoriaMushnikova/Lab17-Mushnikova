/*int[] scores = { 60, 80, 40, 80, 90 };*/
/*int sum = 0;
foreach (int score in scores)
{
    sum += score;
}
int SumArray(int[] numbers)
{
    int sum = 0;

    foreach (int number in numbers)
    {
        sum += number;
    }

    return sum;
}
Console.WriteLine(SumArray(scores));*/


/*int SumArray(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
Console.WriteLine(SumArray(new int[] { 5, -2, 7 }));*/



/*int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(CountAtLeast(scores, 50));*/


/*int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;

    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80}, 50));*/


/*int FindMax(int[] numbers)
{
    int max = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
int FindMin(int[] numbers)
{
    int min = numbers[0];

    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
Console.WriteLine(FindMax(scores));
Console.WriteLine(FindMin(scores));*/


/*int FindMin(int[] numbers)
{
    int min = numbers[0];
    foreach (int number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }
    return min;
}
Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));*/


/*int FindIndex(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}
Console.WriteLine(FindIndex(scores, 80));
Console.WriteLine(FindIndex(scores, 100));*/


/*int FindIndex(int[] numbers, int target)
{
    int index = -1;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return index;
}
Console.WriteLine(FindIndex(scores, 80));
Console.WriteLine(FindIndex(scores, 60));
Console.WriteLine(FindIndex(scores, 100));*/


using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Text.RegularExpressions;

int[] scores = new int[7];
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine()!);
}
int SumArray(int[] numbers)
{
    int sum = 0;
    foreach (int number in numbers)
    {
        sum += number;
    }
    return sum;
}
int FindMin(int[] numbers)
{
    int min = numbers[0];
    foreach (int number in numbers)
    {
        if (min > number)
        {
            min = number;
        }
    }
    return min;
}
int FindMax(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (max < number)
        {
            max = number;
        }
    }
    return max;
}
int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}
Console.WriteLine(">>> Анализ результатов <<<");
Console.WriteLine($"Сумма: {SumArray(scores)}");
Console.WriteLine($"Минимум: {FindMin(scores)}");
Console.WriteLine($"Максимум: {FindMax(scores)}");
Console.WriteLine($"Результатов 50 и больше: {CountAtLeast(scores, 50)}");
Console.WriteLine("Какой результат найти: ");
int target = Convert.ToInt32(Console.ReadLine()!);
int FindIndex(int[] numbers, int target)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}
int index = FindIndex(scores, target);
if (index == -1)
{
    Console.WriteLine("Результат не найден");
}
else
{
    Console.WriteLine($"Первый индекс: {index}");
}

Console.WriteLine("Самостоятельное задание");
Console.WriteLine("Вариант 3");
int FindLastIndex(int[] numbers, int target)
{
    for (int i = numbers.Length - 1; i >= 0; i--)
    {
        if (numbers[i] == target)
        {
            return i;
        }
    }
    return -1;
}
int[] indexLast = new int[] { 5, 8, 6, 10, 5 };
Console.WriteLine(FindLastIndex(indexLast, 5));
Console.WriteLine(FindLastIndex(indexLast, 7));
