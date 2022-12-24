namespace Losev
{
    internal class Sorting
    {
        public static int[] Sort(int[] data)
<<<<<<< HEAD
        {           
=======
        {
            int[] chk = new int[data.Length];
            Array.Copy(data, chk, data.Length);
>>>>>>> 11935fcea55774696a955ef785e52a4302979f06
            int l = 0;
            int r = data.Length - 1;
            int b = 1;
            Stack<int[]> stack = new Stack<int[]>(10);
            while (true)
            {
                int[] temp;
                if (l != r)
                {
                    int i = l;
                    int j = r;

                    while (i <= j)
                    {
                        if (CheckBit(data[i], b, 10))
                        {
                            do
                            {
                                j--;
                                if (i <= j)
                                {
                                    if (!CheckBit(data[j + 1], b, 10))
                                    {
                                        Swap(i, j + 1, ref data);
                                        break;
                                    }
                                }

                            } while (i <= j);
                        }
                        i++;
                    }

                    b++;
                    if (!(b > 10))
                    {
                        if (j < l || j == r)
                        {
                            continue;
                        }
                        if (j == l)
                        {
                            l++;
                            continue;
                        }
                        stack.Push(new int[] { r, b });
                        r = j;
                        continue;
                    }

                }

                if (stack.TryPop(out temp))
                {
                    l = r + 1;
                    r = temp[0];
                    b = temp[1];
                    continue;
                }
                break;


            }

            return data;
        }

        private static bool CheckBit(int input, int bit, int maxBit)
        {
<<<<<<< HEAD
=======
            int temp = (input & (int)Math.Pow(2, maxBit - bit));
            int temp2 = (int)Math.Pow(2, maxBit - bit);
>>>>>>> 11935fcea55774696a955ef785e52a4302979f06
            return (input & (int)Math.Pow(2, maxBit - bit)) == (int)Math.Pow(2, maxBit - bit);
        }
        private static void Swap(int a, int b, ref int[] data)
        {
            int temp;
            temp = data[a];
            data[a] = data[b];
            data[b] = temp;

        }

    }


}
