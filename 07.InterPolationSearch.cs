using System;

class InterpolationSearch
{
    static int InterpolationSearch(int[] arr, int low, int high, int target)
    {
        // While the search range is valid and the target is within the current range
        while (low <= high && target >= arr[low] && target <= arr[high])
        {
            // If the array contains only one element
            if (low == high)
            {
                if (arr[low] == target)
                    return low;
                return -1;
            }

            // Calculate the position using the interpolation formula
            int pos = low + ((target - arr[low]) * (high - low)) / (arr[high] - arr[low]);

            // If the target is found at the calculated position
            if (arr[pos] == target)
                return pos;

            // If the target is larger, search the right subarray
            if (arr[pos] < target)
                low = pos + 1;
            // If the target is smaller, search the left subarray
            else
                high = pos - 1;
        }
        // If the target is not found
        return -1;
    }

    static void Main(string[] args)
    {
        int[] arr = { 10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 };
        int n = arr.Length;
        int target = 18;

        // Perform interpolation search
        int index = InterpolationSearch(arr, 0, n - 1, target);

        if (index != -1)
            Console.WriteLine("Target value found at index {0}.", index);
        else
            Console.WriteLine("Target value not found.");
    }
}
