using System;
using System.Linq;
using System.Text;

namespace Task2
{
    internal static class NumberParserHelper
    {
        internal static string Normalize(this string stringValue, out bool isNegative)
        {
            if (string.IsNullOrWhiteSpace(stringValue) || string.IsNullOrEmpty(stringValue))
                throw new FormatException(nameof(stringValue));

            isNegative = false;
            if (stringValue[0] == '-')
                isNegative = true;

            var stringBuilder = new StringBuilder();

            (stringValue[0] == '-' || stringValue[0] == '+'
                ? stringValue[1..].Where(x => x != ' ')
                : stringValue.Where(x => x != ' '))
                    .Aggregate(stringBuilder, (x, y) => char.IsDigit(y)
                        ? x.Append(y)
                        : throw new FormatException(nameof(stringValue)));

            return stringBuilder.ToString();
        }

        internal static int ToInt(this char character) =>
            character switch
            {
                '0' => 0,
                '1' => 1,
                '2' => 2,
                '3' => 3,
                '4' => 4,
                '5' => 5,
                '6' => 6,
                '7' => 7,
                '8' => 8,
                '9' => 9,
                _ => throw new FormatException("Invalid number!")
            };
    }
}
