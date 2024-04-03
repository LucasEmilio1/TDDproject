public class FatorialCalculator
    {
        public static int CalcFato(int n)
        {
            int fatorial = 1;
            for (int f = 1; f <= n; f++)
            {
                fatorial = fatorial* f;
            }
            return fatorial;
        }
    }