namespace Data
{
    public class SortService
    {
        private readonly BubbleSort bubbleSort;
        private readonly MergeSort mergeSort;

        public SortService()
        {
            bubbleSort = new BubbleSort();
            mergeSort = new MergeSort();
        }

        public List<int> SortNumbers(string sortAlgorithm, List<int> randomNumbers)
        {
            if (sortAlgorithm == "bubbleSort")
            {
                return bubbleSort.Sort(randomNumbers);
            }
            return mergeSort.Sort(randomNumbers);
        }
    }
}
