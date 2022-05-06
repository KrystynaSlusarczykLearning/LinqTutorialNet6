using System.Collections.Generic;
using System.Linq;

namespace ExercisesTests.Utilities
{
    public static class TestUtilities
    {
        public static string EnumerableToString<T>(
            IEnumerable<T> input, string separator = ", ")
        {
            return $"({string.Join(separator, input)})";
        }

        public static string DictionaryToString<TKey, TValue>(Dictionary<TKey, TValue> input)
        {
            var str = string.Join(", ", input.Select(kv => KeyValuePairToString(kv)));
            return $"({str})";
        }

        public static string KeyValuePairToString<TKey, TValue>(KeyValuePair<TKey, TValue> kv)
        {
            var value = kv.Value == null ? "null" : kv.Value.ToString();
            return $"({kv.Key}:{value})";
        }
    }
}
