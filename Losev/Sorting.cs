namespace Losev
{
    internal class Sorting
    {
        public static int[] Sort(int[] data)
        {

            int N = data.Length;

            for (int i = N / 2 - 1; i >= 0; i--)
                Heapify(data, N, i);

            for (int i = N - 1; i > 0; i--)
            {
                Swap(0, i, ref data);
                Heapify(data, i, 0);
            }
            return data;
        }
        private static void Swap(int a, int b, ref int[] data)
        {
            int temp;
            temp = data[a];
            data[a] = data[b];
            data[b] = temp;

        }

        private static void Heapify(int[] arr, int N, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;
            if (l < N && arr[l] > arr[largest])
                largest = l;
            if (r < N && arr[r] > arr[largest])
                largest = r;
            if (largest != i)
            {
                Swap((int)largest, i, ref arr);            
                Heapify(arr, N, largest);
            }
        }

    }
}
