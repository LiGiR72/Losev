namespace Losev
{
    internal class Sorting
    {
        private static DataSets dataset = new DataSets();

        public static void Test()
        {
            int[] data = dataset.GetData(50, 1000);
            Thread.Sleep(1000);
        }

        public int[] Sort(int amount)
        {
            int[] data = dataset.GetData(amount, 1000);
            int[] eqTable = new int[data.Length];
            int[] output = new int[data.Length];
            for (int i = 0; i < eqTable.Length; i++)
            {
                eqTable[i] = 0;
            }
            for (int i = data.Length - 1; i > 0; i--)
            {
                for (int j = i - 1; j >= 0; j--)
                {

                    if (data[i] > data[j])
                    {
                        eqTable[i]++;
                    }
                    else
                    {
                        eqTable[j]++;
                    }
                }
            }
            for (int i = 0; i < data.Length; i++)
            {
                output[eqTable[i]] = data[i];
            }
            return output;
        }
    }
}
