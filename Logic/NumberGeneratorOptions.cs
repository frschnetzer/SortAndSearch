namespace Logic
{
    public class NumberGeneratorOptions : INumberGeneratorOptions
    {
        public int Count { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public bool AllowDuplicates { get; set; }

        // Calculating the Range of Maximum and Minimum + 1
        // +1 is needed to allow same count and max value
        public int ValueRange => MaxValue - MinValue +1;

        public NumberGeneratorOptions(int count, int minValue, int maxValue, bool allowDuplicates)
        {
            if (count < 1)
                throw new ArgumentException("Count must be greater than zero");
            if (minValue > maxValue)
                throw new ArgumentException("Minimum value must be less than or equal to Maximum value");

            Count = count;
            MinValue = minValue;
            MaxValue = maxValue;
            AllowDuplicates = allowDuplicates;
        }
    }
}
