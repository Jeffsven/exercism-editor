namespace Difference_Of_Squares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static int CalculateSquareOfSum(int max)
        {
            int sum = Enumerable.Range(1, max).Select(x => x).Sum();
            int value = (int)Math.Pow(sum, 2);
            return value;
        }
        public static int CalculateSumOfSquares(int max)
        {
            var value = Enumerable.Range(1, max).Select(x => (int)Math.Pow(x, 2)).Sum();
            return value;
        }
        public static int CalculateDifferenceOfSquares(int max)
        {
            return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        }
    }


}