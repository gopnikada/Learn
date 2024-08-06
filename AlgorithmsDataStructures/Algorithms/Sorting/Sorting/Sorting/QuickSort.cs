namespace Sorting
{
    public static class QuickSort
    {
        public static int[] Sort(int[] array)
        {
            return SortArray(array, 0, array.Length - 1);
        }
        private static int[] SortArray(int[] array, int leftIndex, int rightIndex)
        {
            var i = leftIndex;
            var j = rightIndex;
            var pivot = array[leftIndex];

            while (i <= j)
            {
                //skip left elements that are less than pivot
                while (array[i] < pivot)
                {
                    i++;
                }

                //skip right elements that are larger than pivot
                while (array[j] > pivot)
                {
                    j--;
                }
                //swap
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
                SortArray(array, leftIndex, j);
            if (i < rightIndex)
                SortArray(array, i, rightIndex);

            return array;
        }
    }
}
