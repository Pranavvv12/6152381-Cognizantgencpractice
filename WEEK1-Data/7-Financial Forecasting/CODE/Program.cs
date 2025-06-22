using System;

class FinancialForecast
{
    public static double PredictFutureValue(double currentValue, double growthRate, int years)
    {
        if (years == 0)
        {
            return currentValue;
        }
        double nextValue = currentValue * (1 + growthRate);
        return PredictFutureValue(nextValue, growthRate, years - 1);
    }

    static void Main(string[] args)
    {
       

        double currentValue = 10000;
        double growthRate = 0.10;
        int years = 5;

        double futureValue = PredictFutureValue(currentValue, growthRate, years);

        Console.WriteLine($"Starting Value: ₹{currentValue}");
        Console.WriteLine($"Annual Growth Rate: {growthRate * 100}%");
        Console.WriteLine($"Years to Forecast: {years}");
        Console.WriteLine($"Predicted Future Value after {years} years: ₹{futureValue:F2}");
    }
}
