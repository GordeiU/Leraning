using System.Collections.Generic;

namespace Learning.Shared.Classes.LeetCode.Easy {
    public static class SolutionConvertRomanNumber {
        private static readonly IReadOnlyDictionary<char, int> RomanIntegerValues = new Dictionary<char, int> {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };

        public static int ConvertRomanNumber(string number) {
            int result = 0;
            int idx;

            for (idx = 0; idx < number.Length - 1; idx++) {
                if (RomanIntegerValues[number[idx]] < RomanIntegerValues[number[idx + 1]]) {
                    result += RomanIntegerValues[number[idx + 1]] - RomanIntegerValues[number[idx]];
                    idx++;
                } else if (RomanIntegerValues[number[idx]] == RomanIntegerValues[number[idx + 1]]) {
                    result += (RomanIntegerValues[number[idx]] * 2);
                    idx++;
                } else {
                    result += RomanIntegerValues[number[idx]];
                }
            }

            if (idx < number.Length) {
                result += RomanIntegerValues[number[idx]];
            }

            return result;
        }
    }
}