using Logic;
using System.Collections.Generic;

namespace Data
{
    public class BubbleSort : ISortAlgorithm
    {
        public List<int> Sort(List<int> list)
        {
            List<int> sortedList = new(list); // create a new list with the same elements as the original list

            int n = sortedList.Count;
            bool swapped;

            do
            {
                swapped = false;
                for (int i = 1; i < n; i++) // iterate over the list from the second element to the last
                {
                    if (sortedList[i - 1] > sortedList[i]) // if the current element is greater than the next element
                    {
                        int temp = sortedList[i - 1]; // swap the current element with the next element
                        sortedList[i - 1] = sortedList[i];
                        sortedList[i] = temp;
                        swapped = true; // set the swapped flag to true indicating that a swap occurred
                    }
                }
                n--;
            } while (swapped); // continue the loop as long as a swap occurred in the previous pass

            return sortedList; // return the sorted list
        }

    }
}
