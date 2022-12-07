// Do Prokin D.S.

int[] array = new int[1000];
int min = int.MaxValue;
int max = int.MinValue;
double average = 0.00;
double sum = 0.00;
double buf1 = 0.0;
double standardDeviation = 0.00;
double depression = 0.00;

Console.WriteLine("Type >=1000 numbers in the row(like 1 2 3 4.. etc) if you wanna end typing press Enter: ");

array = Console.ReadLine().Split().Select(int.Parse).ToArray();

void FindMin()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Minimum number: {min}");
}

void FindMax()
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    Console.WriteLine($"Maximum number: {max}");
}

void FindAverage()
{
    for (int i = 0; i < array.Length; i++) // for average num.
    {
        sum += array[i];
    }
    average = sum / array.Length;
    Console.WriteLine($"Average number: {Math.Round(average, 2)}");
}

void FindStandardDevation()
{
    sum = 0.0;
    for (int i = 0; i < array.Length; i++) // standard deviation
    {
        buf1 = 0.0;
        buf1 = array[i];
        buf1 -= average;
        buf1 = Math.Pow(buf1, 2);
        sum += buf1;
    }
    depression = sum / array.Length;
    standardDeviation = Math.Sqrt(depression);

    Console.WriteLine($"Standard deviation: {Math.Round(standardDeviation, 2)}");
}

FindMin();
FindMax();
FindAverage();
FindStandardDevation();