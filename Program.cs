int[] scores = { 60, 80, 40, 80, 90 };
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



int count = 0;
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
Console.WriteLine(CountAtLeast(scores, 50));