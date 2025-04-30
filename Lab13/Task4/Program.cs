using System;

class Program
{
    public delegate int RandomValueDelegate();

    static void Main(string[] args)
    {
        RandomValueDelegate[] delegateArray = new RandomValueDelegate[5];

        Random random = new Random();
        for (int i = 0; i < delegateArray.Length; i++)
        {
            delegateArray[i] = () => random.Next(1, 101); 
        }

        Func<RandomValueDelegate[], double> calculateAverage = (delegates) =>
        {
            int sum = 0;
            foreach (var del in delegates)
            {
                sum += del(); 
            }
            return (double)sum / delegates.Length; 
        };

        double average = calculateAverage(delegateArray);

        Console.WriteLine($"Среднее арифметическое значений: {average:F2}");
    }
}
