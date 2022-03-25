using System;
using System.Linq;
using System.Text;

namespace Task2
{
    internal static class NumberParserHelper
    {
        private const int zeroCharOffset = 48;
        internal static string Normalize(this string stringValue, out bool isNegative)
        {
            if (string.IsNullOrWhiteSpace(stringValue) || string.IsNullOrEmpty(stringValue))
                throw new FormatException(nameof(stringValue));

            isNegative = stringValue[0] == '-';

            var stringBuilder = new StringBuilder();

            var res = stringValue.TrimStart().TrimEnd();

            if (res[0] == '-' || res[0] == '+')
                res = res[1..];

            return res.All(x => char.IsDigit(x)) ? res : throw new FormatException(nameof(res));
        }

        internal static int ToInt(this char character) => (int)character - zeroCharOffset;
    }
}
