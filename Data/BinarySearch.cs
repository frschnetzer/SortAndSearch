using Logic;

namespace Data
{
    public class BinarySearch : ISearchAlgorithm
    {
        public (int,int) Search(List<int> list, int searchedNumber)
        {
            int left = 0; // initialize the left pointer to the start of the list
            int right = list.Count - 1; // initialize the right pointer to the end of the list

            while (left <= right) // continue the loop as long as the left pointer is less than or equal to the right pointer
            {
                int mid = (left + right) / 2; // calculate the middle

                if (list[mid] == searchedNumber) // if the middle element is equal to the searched number
                {
                    return (mid, searchedNumber); // return the position (mid) and the value (searchedNumber)
                }
                else if (list[mid] < searchedNumber) // if the middle element is less than the searched number
                {
                    left = mid + 1; // move the left pointer to the element on the right side of the middle
                }
                else // if the middle element is greater than the searched number
                {
                    right = mid - 1; // move the right pointer to the element on the left side of the middle
                }
            }

            // If the number is not found, return -1 as the position and value.
            return ( -1, -1 );
        }
    }

}
