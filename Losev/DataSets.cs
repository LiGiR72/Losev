namespace Losev
{
    internal class DataSets
    {
        private Random random;

        public DataSets()
        {
            random = new Random();
        }
        public DataSets(int seed)
        {
            random = new Random(seed);
        }
       
        public int[] GetData(int amount, int border)
        {
            int[] output = new int[amount];
            for (int i = 0; i < amount; i++)
            {
                output[i] = random.Next(border);
            }
            return output;
        }
    }
}
