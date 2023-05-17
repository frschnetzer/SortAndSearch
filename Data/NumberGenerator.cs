using Logic;

namespace Data
{
    public class NumberGenerator
    {
        /// <summary>
        /// Generating a random number list eather with or without duplicates
        /// </summary>
        /// <param name="options">Set count, minimum and maximum value of the list</param>
        /// <returns>Generated list of numbers</returns>
        public static List<int> GenerateNumbers(INumberGeneratorOptions options)
        {
            Random random = new();
            List<int> numbers = new();

            while (numbers.Count < options.Count)
            {
                // generating random number from min to max value
                int number = random.Next(options.MinValue, options.MaxValue + 1);

                if (!options.AllowDuplicates && !numbers.Contains(number))
                {
                    // List without duplicates
                    numbers.Add(number);
                }
                else if(options.AllowDuplicates)
                {
                    // List with duplicates
                    numbers.Add(number);
                }
            }
            return numbers;
        }
    }
}
