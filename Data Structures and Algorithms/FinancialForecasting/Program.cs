using System;
namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialAmount =10000;
            double growthRate =0.10;
            int years =5;
            double result =Forecast.CalculateFutureValue(initialAmount,growthRate,years);
            Console.WriteLine("Initial Amount: "+ initialAmount);
            Console.WriteLine("Growth Rate: "+ (growthRate * 100)+ "%");
            Console.WriteLine("Years: "+ years);
            Console.WriteLine("Future Value: "+ result);
        }
    }
}