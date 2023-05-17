namespace Logic
{
    public interface ISearchAlgorithm
    {
        (int, int) Search(List<int> list, int number);
    }
}
