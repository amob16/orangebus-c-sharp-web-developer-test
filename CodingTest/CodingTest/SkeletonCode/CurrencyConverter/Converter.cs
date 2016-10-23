using System;

namespace SkeletonCode.CurrencyConverter
{
	public class Converter
	{
		public decimal Convert(string inputCurrency, string outputCurrency, decimal amount)
		{
            if ((inputCurrency != "USD" && inputCurrency != "GBP") || (outputCurrency != "USD" && outputCurrency != "GBP"))
            {
                throw new Exception("Error");
            }

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
