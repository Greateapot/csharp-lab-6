using System.Text.RegularExpressions;

namespace Lab6
{
    public partial class Tasks
    {
        /// <summary>
        /// Найти сумму всех четных элементов, которые находятся между первым минимальным элементом и последним 
        /// максимальным элементом массива. Минимальных и максимальных элементов в массиве может быть несколько.
        /// </summary>
        /// <param name="array">Одномерный массив</param>
        /// <returns>индекс первого минимального элемента, индекс последнего максиамльного элемента, сумма</returns>
        public static (int, int, int) TaskCalcSum(int[] array)
        {
            var minIndex = Array.IndexOf(array, array.Min());
            var maxIndex = Array.LastIndexOf(array, array.Max());
            var sum = 0;

            {
                var realMinIndex = minIndex < maxIndex ? minIndex : maxIndex;
                var realMaxIndex = minIndex == realMinIndex ? maxIndex : minIndex;
                for (var index = realMinIndex + 1; index < realMaxIndex; index++)
                    if (array[index] % 2 == 0)
                        sum += array[index];
            }

            return (minIndex, maxIndex, sum);
        }

        /// <summary>
        /// Определить есть ли в строке идентификаторы, если есть, то напечатать самый короткий идентификатор.
        /// </summary>
        /// <param name="source">Входная строка</param>
        /// <returns>самый короткий идентификатор или null, если его нет</returns>
        public static string? TaskFindMinIdentifier(string source)
        {
            string? shortestIdentifier = null;
            foreach (var item in StringIdentifier().Matches(source).AsEnumerable())
                if (shortestIdentifier == null || item.Value.Length < shortestIdentifier.Length)
                    shortestIdentifier = item.Value;
            return shortestIdentifier;
        }

        [GeneratedRegex("[a-zA-Z_]+([a-zA-Z0-9_]*)?")]
        private static partial Regex StringIdentifier();
    }
}