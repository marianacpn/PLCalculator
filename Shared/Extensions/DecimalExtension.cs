using Shared.Constants;

namespace Shared.Extensions
{
    public static class DecimalExtension
    {
        public static string ToStringCurrencyFormat(this decimal value) => $"R$ {value.ToString($"N2", SystemConst.DEFAULT_CULTURE)}";
    }
}
