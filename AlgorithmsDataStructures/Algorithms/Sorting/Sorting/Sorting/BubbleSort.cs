namespace Sorting
{
    public static class BubbleSort
    {
        public static int[] Sort(int[] array)
        {

            int length = array.Length;

            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < array.Length - i; j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }
    }
}
