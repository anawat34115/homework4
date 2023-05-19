using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of road segments (N) and the distance (K):");
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        Console.WriteLine("Enter the population of each road segment separated by spaces: ");
        string[] populationInput = Console.ReadLine().Split(' ');
        int[] population = new int[N];
        for (int i = 0; i < N; i++)
        {
            population[i] = int.Parse(populationInput[i]);
        }

        int maxCustomers = 0;

        for (int i = 0; i < N; i++)
        {
            int customers = 0;
            for (int j = i - K; j <= i + K; j++)
            {
                if (j >= 0 && j < N)
                {
                    customers += population[j];
                }
            }
            if (customers > maxCustomers)
            {
                maxCustomers = customers;
            }
        }

        Console.WriteLine("Maximum number of customers: " + maxCustomers);
    }
}
