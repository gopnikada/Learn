namespace Sorting
{
    public static class RadixSort
    {
        public static int[] Sort(int[] array)
        {
            // Find the maximum value to know how many digits are needed
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            // Loop through each digit
            for (int digit = 1; max / digit > 0; digit *= 10)
            {
                // Create buckets for each digit based on the digit place
                int[] buckets = new int[10];

                // Loop through the array and place each item in the appropriate bucket
                for (int i = 0; i < array.Length; i++)
                {
                    int bucketIndex = array[i] / digit % 10;
                    buckets[bucketIndex]++;
                }

                // Loop through the buckets and build the array
                int index = 0;
                for (int bucket = 0; bucket < buckets.Length; bucket++)
                {
                    for (int i = 0; i < buckets[bucket]; i++)
                    {
                        array[index++] = bucket * digit;
                    }
                }
            }

            return array;
        }
    }
}
