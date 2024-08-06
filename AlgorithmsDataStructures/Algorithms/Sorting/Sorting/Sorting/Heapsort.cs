namespace Sorting
{
    public static class Heapsort
    {
        public static int[] Sort(int[] array)
        {
            int size = array.Length;

            if (size <= 1)
                return array;

            //build init max heap
            for (int i = size / 2 - 1; i >= 0; i--)
            {
                MaxHeapify(array, size, i);
            }

            //swap max element with first
            for (int i = size - 1; i >= 0; i--)
            {
                var tempVar = array[0];
                array[0] = array[i];
                array[i] = tempVar;
                MaxHeapify(array, i, 0);
            }
            return array;
        }
        static void MaxHeapify(int[] array, int size, int index)
        {
            var largestIndex = index;
            var leftChild = 2 * index + 1;
            var rightChild = 2 * index + 2;

            if (leftChild < size && array[leftChild] > array[largestIndex])
            {
                largestIndex = leftChild;
            }
            if (rightChild < size && array[rightChild] > array[largestIndex])
            {
                largestIndex = rightChild;
            }
            if (largestIndex != index)
            {
                var tempVar = array[index];
                array[index] = array[largestIndex];
                array[largestIndex] = tempVar;
                MaxHeapify(array, size, largestIndex);
            }
        }
    }
}
