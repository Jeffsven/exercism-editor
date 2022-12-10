namespace Beer_Song
{
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BeerSong.Recite(1,1));
        }
    }
    public static class BeerSong
    {
        public static string Recite(int startBottles, int takeDown)
        {
            List<string> list = new List<string>();

            while (list.Count < takeDown)
            {
                string s = startBottles is 0 ? $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall." :
                    $"{startBottles} bottle{(startBottles > 1 ? "s" : "")} of beer on the wall, {startBottles} bottle{(startBottles > 1 ? "s" : "")} of beer.\nTake {(startBottles is 1 ? "it" : "one")} down and pass it around, {(--startBottles is 0 ? "no more" : startBottles)} bottle{(startBottles is 1?"":"s")} of beer on the wall.";

                list.Add(s);
            }
            
            return string.Join("\n\n", list);
        }
    }
}