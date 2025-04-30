using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Трехзначные автоморфные числа:");

        for (int num = 100; num <= 999; num++)
        {
            int square = num * num;
            string numStr = num.ToString();
            string squareStr = square.ToString();

            if (squareStr.EndsWith(numStr))
            {
                Console.WriteLine(num);
            }
        }
    }
}
