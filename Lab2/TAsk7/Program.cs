using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Выберите оператор цикла для выполнения задачи:");
        Console.WriteLine("1 - while");
        Console.WriteLine("2 - do while");
        Console.WriteLine("3 - for");

        Console.Write("Введите номер выбранного варианта: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                int i = 1;
                while (i <= 101)
                {
                    Console.Write(i + " ");
                    i += 2;
                }
                break;

            case 2:
                int j = 1;
                do
                {
                    Console.Write(j + " ");
                    j += 2;
                } while (j <= 101);
                break;

            case 3:
                for (int k = 1; k <= 101; k += 2)
                {
                    Console.Write(k + " ");
                }
                break;

            default:
                Console.WriteLine("Ошибка: выберите вариант от 1 до 3.");
                break;
        }
    }
}
