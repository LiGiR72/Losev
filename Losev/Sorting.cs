namespace Losev
{
    internal class Sorting
    {
        public static int[] Sort(int[] data)
        {
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
