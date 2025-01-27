/*
 * What is Binary Search?
 * Binary Search is an efficient algorithm used to find a target value within a sorted array.
 * It repeatedly divides the search range in half, eliminating half of the remaining elements each time.
 *
 * Steps:
 * 1. Start with the entire array as the search range.
 * 2. Find the middle element.
 * 3. Compare the middle element to the target:
 *    - If it matches, return the index.
 *    - If the target is smaller, search the left half.
 *    - If the target is larger, search the right half.
 * 4. Repeat until the target is found or the search range is empty.
 *
 * Time Complexity:
 * - Best case: O(1) (target is at the middle)
 * - Worst case: O(log n)
 *
 * Usage in Games:
 * Binary Search can be used in several gaming scenarios, including:
 *
 * 1. **Inventory Management**:
 *    - Quickly find an item in a sorted inventory (e.g., weapons sorted by damage or items sorted by rarity).
 *
 * 2. **Leaderboard Ranking**:
 *    - Determine a player's rank in a sorted leaderboard based on their score.
 *
 * 3. **AI Decision Making**:
 *    - Efficiently select the optimal action or response from a sorted list of possible moves.
 *
 * 4. **Level Progression**:
 *    - Find the correct level or stage in a sorted list of levels based on the player's progress.
 *
 * Example Scenario:
 * In a game with a crafting system, materials in the inventory are sorted by type or rarity. 
 * Binary Search can be used to quickly locate a specific material when crafting an item.
 */
using System;

public class BinarySearch
{
    public static void Main(string[] args)
    {
        // Sorted array for binary search
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };

        // Target value to search
        int target = 7;

        // Perform binary search
        int index = BinarySearch(sortedArray, target);

        // Print the result
        if (index != -1)
        {
            Console.WriteLine($"Target {target} found at index {index}.");
        }
        else
        {
            Console.WriteLine($"Target {target} not found in the array.");
        }
    }

    public static int BinarySearch(int[] array, int target)
    {
        int left = 0; // Start of the search range
        int right = array.Length - 1; // End of the search range

        while (left <= right)
        {
            // Calculate the middle index
            int mid = left + (right - left) / 2;

            // Check if the target is at the middle
            if (array[mid] == target)
            {
                return mid; // Target found
            }

            // If target is smaller, ignore the right half
            if (array[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                // If target is larger, ignore the left half
                left = mid + 1;
            }
        }

        return -1; // Target not found
    }
}
