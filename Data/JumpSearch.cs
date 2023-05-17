using Logic;

namespace Data
{
    public class JumpSearch : ISearchAlgorithm
    {
        // JUMP SEARCH
        // 1. determine the block size by taking the square root of the size of the sorted list
        // 2.jumps form one block to another until it finds a block where the last element 
        //      is greater than the searched number
        // 3. once a relevant block is identified -> linear search 
        // Linear Search: scans through each element in a list until it finds the value
        //public (int, int) Search(List<int> sortedList, int searchedNumber)
        //{
        //    int blockSize = (int)Math.Sqrt(sortedList.Count); // calculate the block size based on the square root of the list size
        //    int start = 0; // initialize the start index of the current block
        //    int end = blockSize; // initialize the end index of the current block

        //    while (end < sortedList.Count && sortedList[end] <= searchedNumber)
        //    {
        //        // move to the next block if the current block's end is less than or equal to the searched number
        //        start = end;
        //        end += blockSize;
        //    }

        //    // perform linear search within the identified block
        //    for (int i = start; i <= Math.Min(end, sortedList.Count - 1); i++)
        //    {
        //        if (sortedList[i] == searchedNumber) // if the element matches the searched number
        //        {
        //            return (i, sortedList[i]); // return the position (i) and the value (sortedList[i])
        //        }
        //    }

        //    // if the number is not found, return -1 as the position and value.
        //    return (-1, -1);
        //}

        // New Jump Search with Recursion
        public (int, int) Search(List<int> sortedList, int searchedNumber)
        {
            int blockSize = (int)Math.Sqrt(sortedList.Count);
            return JumpSearchRecursive(sortedList, searchedNumber, 0, blockSize);
        }

        private (int, int) JumpSearchRecursive(List<int> sortedList, int searchedNumber, int start, int blockSize)
        {
            if (start >= sortedList.Count)
            {
                return (-1, -1); // Number not found
            }

            int end = Math.Min(start + blockSize, sortedList.Count) - 1;

            if (sortedList[end] >= searchedNumber)
            {
                if (sortedList[start] == searchedNumber)
                {
                    return (start, sortedList[start]); // Number found at the start index
                }

                return JumpSearchRecursive(sortedList, searchedNumber, start + 1, blockSize);
            }

            return JumpSearchRecursive(sortedList, searchedNumber, end + 1, blockSize);
        }

    }
}
