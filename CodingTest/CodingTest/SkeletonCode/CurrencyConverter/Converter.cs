using System;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            decimal conversionRatio = 1.25m;

            if(inputCurrency == "USD" && outputCurrency == "GBP")
            {
                conversionRatio = 0.8m;
            }

            amount = Decimal.Multiply(amount, conversionRatio);

			return amount;
		}
	}
}
