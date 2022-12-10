namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Triangle.IsScalene(5,4,6));
        }
    }

    public static class Triangle
    {
        public static bool IsScalene(double side1, double side2, double side3)
        {
            if (!CheckExtra(side1, side2, side3)) return false;
            return (side1 != side2) && (side1 != side3) && (side2 != side3);
        }

        public static bool IsIsosceles(double side1, double side2, double side3)
        {
            if (!CheckExtra(side1, side2, side3)) return false;
            return (side1 == side2) || (side1 == side3) || (side2 == side3);
        }

        public static bool IsEquilateral(double side1, double side2, double side3)
        {
            if (!CheckExtra(side1, side2, side3)) return false;
            return (side1 == side2) && (side1 == side3) && (side2 == side3);
        }

        private static bool CheckExtra(double side1, double side2, double side3)
        {
            if (side1 is 0 || side2 is 0 || side3 is 0) return false;
            return (side1 + side2 >= side3) && (side1 + side3 >= side2) && (side2 + side3 >= side1);
        }
    }
}