namespace TheElasticProject
{
    public static class Solution
    {
        public static void Main(string[] args)
        {
            int[] transferAmounts = new int[] { 2, 4, 1, 1, 2 };
            string recipients = "BAABA";

            //int[] transferAmounts = new int[] { 10, 5, 10, 15 };
            //string recipients = "ABAB";

            //int[] transferAmounts = new int[] { 100 };
            //string recipients = "B";

            solution(recipients, transferAmounts);
        }

        public static int[] solution(string R, int[] V)
        {
            int minAmountA = 0;
            int minAmountB = 0;

            int balanceA = 0;
            int balanceB = 0;

            for (int i = 0; i < R.Length; i++)
            {
                if (R[i] == 'A')
                {
                    balanceA += V[i];
                    balanceB -= V[i];

                    if (balanceB < minAmountB)
                    {
                        minAmountB = balanceB;
                    }
                }
                else if (R[i] == 'B')
                {
                    balanceB += V[i];
                    balanceA -= V[i];

                    if (balanceA < minAmountA)
                    {
                        minAmountA = balanceA;
                    }
                }
            }
            Console.WriteLine(-minAmountA);
            Console.WriteLine(-minAmountB);

            var initialBalances = new int[] { -minAmountA, -minAmountB };

            return initialBalances;
        }
    }
}