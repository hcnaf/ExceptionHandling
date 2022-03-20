using System;
using System.Linq;

namespace Task2
{
    public class NumberParser : INumberParser
    {
        public int Parse(string stringValue)
        {
            if (stringValue is null)
                throw new ArgumentNullException(nameof(stringValue));

            var res = 0;
            var normalizedStringValue = stringValue.Normalize(out var isNegative);
            var numberOfDigits = normalizedStringValue.Length;
            res = isNegative
                ? checked(normalizedStringValue.Aggregate(res,
                    (x, y) => x - y.ToInt() * (int)Math.Pow(10, --numberOfDigits)))
                : checked(normalizedStringValue.Aggregate(res,
                    (x, y) => x + y.ToInt() * (int)Math.Pow(10, --numberOfDigits)));

            return res;
        }
	}
}
