namespace Data
{
    public class SearchService
    {
        private readonly BinarySearch binarySearch;
        private readonly JumpSearch jumpSearch;
        public SearchService()
        {
            binarySearch = new BinarySearch();
            jumpSearch = new JumpSearch();
        }

        public (int,int) SearchNumbes(string searchAlgorithm, List<int> sortedmNumbers, int searchedNumber)
        {
            if(searchAlgorithm == "binary")
            {
                return binarySearch.Search(sortedmNumbers, searchedNumber);
            }
            return jumpSearch.Search(sortedmNumbers, searchedNumber);
        }
    }
}