namespace Scrabble_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ScrabbleScore.Score("cabbage"));
        }
    }

    public static class ScrabbleScore
    {
        public static int Score(string input)
        {
            int score = 0;

            foreach (var s in input.ToUpper())
            {
                switch (s)
                {
                    case char one when "A, E, I, O, U, L, N, R, S, T".Contains(s): score += 1; break;
                    case char one when "D, G".Contains(s): score += 2; break;
                    case char one when "B, C, M, P".Contains(s): score += 3; break;
                    case char one when "F, H, V, W, Y".Contains(s): score += 4; break;
                    case char one when "K".Contains(s): score += 5; break;
                    case char one when "J, X".Contains(s): score += 8; break;
                    case char one when "Q, Z".Contains(s): score += 10; break;
                }
            }

            return score;
        }
    }
}