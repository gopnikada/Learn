using System.ComponentModel.DataAnnotations;

namespace Sorting
{
    public static class CountingSort
    {
        public static int[] Sort(int[] array)
        {

            // Create a new array to store the sorted values
            int[] sorted = new int[array.Length];

            // Create a new array to store the counts
            int[] count = new int[array.Max()+1];

            // Count the number of times each value appears
            for (int i = 0; i < array.Length; i++)
            {
                int element = array[i];
                count[element]++;
            }

            // Add the previous count to the current count
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Place the values in the sorted array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sorted[count[array[i]] - 1] = array[i];
                count[array[i]]--;
            }

            return sorted;
        }
    }
}
