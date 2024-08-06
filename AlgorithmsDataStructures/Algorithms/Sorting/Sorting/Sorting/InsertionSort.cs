namespace Sorting
{
    public static class InsertionSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;

            for (int sortedIndex = 0; sortedIndex < length - 1; sortedIndex++)
            {
                for (int currentIndex = sortedIndex + 1; currentIndex > 0; currentIndex--)
                {
                    if (array[currentIndex - 1] > array[currentIndex])
                    {
                        int temp = array[currentIndex];
                        array[currentIndex] = array[currentIndex - 1];
                        array[currentIndex - 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}