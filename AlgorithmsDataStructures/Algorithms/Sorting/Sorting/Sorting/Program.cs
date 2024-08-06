namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 1, 2 };
            int[] sorted;
            //iterative sortings
            //sorted = BubbleSort.Sort(array);
            //sorted = SelectionSortImpl.Sort(array);
            //sorted = InsertionSort.Sort(array);

            //recursive sortings
            sorted = Heapsort.Sort(array);

            Console.WriteLine(1);
        }
    }
}
