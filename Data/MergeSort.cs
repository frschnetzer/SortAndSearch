using Logic;

namespace Data
{
    public class MergeSort : ISortAlgorithm
    {
        // method that receives an unsorted list and returns a sorted list
        public List<int> Sort(List<int> list) 
        {
            // call the MergeSortRecursive method to sort the list
            return MergeSortRecursive(list); 
        }

        // recursive method that will split the list and sort its elements
        private List<int> MergeSortRecursive(List<int> list) 
        {
            // if the list contains only one element or is empty, return the list
            if (list.Count <= 1)
            {
                return list;
            }

            // get the middle of the list
            int middle = list.Count / 2;
            List<int> left = new();
            List<int> right = new();

            // iterate from the start of the list to the middle index
            for (int i = 0; i < middle; i++)
            {
                // add the current element to the left list
                left.Add(list[i]);
            }

            // iterate from the middle index to the end of the list
            for (int i = middle; i < list.Count; i++)
            {
                // add the current element to the right list.
                right.Add(list[i]);
            }

            // recursively sort the lists
            left = MergeSortRecursive(left);
            right = MergeSortRecursive(right);

            // merge the two sorted lists and return the result
            return Merge(left, right);
        }

        // method that merges two sorted lists into one sorted list
        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new();

            while (left.Count > 0 || right.Count > 0)
            {
                // if the left and right lists are greater than 0 
                if (left.Count > 0 && right.Count > 0)
                {
                    // if the first number of the left sorted list is smaller than the first number of the right sorted list
                    if (left[0] <= right[0])
                    {
                        // add the first number of the left sorted list to the result list and remove the number from the left list
                        result.Add(left[0]);
                        left.RemoveAt(0);
                    }
                    else
                    {
                        // add the first number of the right sorted list to the result list and remove the number from the right list
                        result.Add(right[0]);
                        right.RemoveAt(0);
                    }
                }
                // if the left list is greater than 0
                else if (left.Count > 0)
                {
                    // adding the first item of the left list to the result list and removing the number from the left list
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                // if the right list is greater than 0
                else if (right.Count > 0)
                {
                    // adding the first item of the right list to the result list an removing the number from the right list
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            // return the merged and sorted list.
            return result;
        }
    }
}