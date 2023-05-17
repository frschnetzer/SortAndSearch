namespace Logic
{
    public interface INumberGeneratorOptions
    {
        int Count { get; set; }
        int MinValue { get; set; }
        int MaxValue { get; set; }
        bool AllowDuplicates { get; set; }
    }
}