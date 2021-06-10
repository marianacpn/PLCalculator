using System;

namespace Shared.Extensions
{
    public static class StringExtension
    {
        public static decimal ToDecimalCurrencyFormat(this string value) => Convert.ToDecimal(value.Replace("R$", "").Trim());
    }
}
