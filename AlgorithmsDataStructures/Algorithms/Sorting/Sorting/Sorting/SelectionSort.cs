namespace Sorting
{
    public static class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            int length = array.Length;

            bool needToSetNewMin = false;

            for(int currentMinimumIndex = 0; currentMinimumIndex < length-1; currentMinimumIndex++)
            {
                int minTempIndex = currentMinimumIndex;

                for(int currentIndex = currentMinimumIndex + 1; currentIndex<length; currentIndex++)
                {
                    if (array[currentIndex] < array[minTempIndex])
                    {
                        minTempIndex = currentIndex;
                        needToSetNewMin = true;
                    }
                }

                if (needToSetNewMin)
                {
                    int temp = array[minTempIndex];
                    array[minTempIndex] = array[currentMinimumIndex];
                    array[currentMinimumIndex] = temp;
                }
            }

            return array;
        }
    }
}