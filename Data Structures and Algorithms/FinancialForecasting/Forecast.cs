using System;
namespace FinancialForecasting
{
    public class Forecast
    {
        public static double CalculateFutureValue(double amount,double growthRate,int years)
        {
            if(years == 0)
            {
                return amount;
            }
            return CalculateFutureValue(amount,growthRate,years - 1)*(1 + growthRate);
        }
    }
}