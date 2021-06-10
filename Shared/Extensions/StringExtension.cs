using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace Shared.Extensions
{
    public enum StringFormatType
    {
        lower = 1,
        upper = 2
    }

    public static class StringExtension
    {
        public static string Normalize(this string value, StringFormatType? toLowerOrUpper = null, bool removeWhiteSpaces = false)
        {
            if (value is null)
                return value;

            if (removeWhiteSpaces)
                value = Regex.Replace(value, @"[^0-9a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ]+", "");
            else
                value = Regex.Replace(value, @"[^ 0-9a-zA-ZáàâãéèêíïóôõöúçñÁÀÂÃÉÈÊÍÏÓÔÕÖÚÇÑ]+", "");

            var normalizedString = value.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            value = stringBuilder.ToString().Normalize(NormalizationForm.FormC);

            value = toLowerOrUpper switch
            {
                StringFormatType.lower => value.ToLower(),
                StringFormatType.upper => value.ToUpper(),
                _ => value
            };

            return value;
        }

        public static decimal ToDecimalCurrencyFormat(this string value) => Convert.ToDecimal(value.Replace("R$", "").Trim());
    }
}
