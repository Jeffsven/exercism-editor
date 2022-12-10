namespace Sum_of_Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfMultiples.Sum(new List<int>() { 0 }, 1));
        }
    }
    public static class SumOfMultiples
    {
        public static int Sum(IEnumerable<int> multiples, int max)
        {
            int sum = 0;
            for (int i = 0; i < max; i++)
            {
                foreach (var m in multiples)
                {
                    if (m is 0) continue;
                    if (i % m is 0)
                    {
                        sum += i;
                        break;
                    }
                }
            }
            return sum;
        }
    }
}