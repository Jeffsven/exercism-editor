namespace Proverb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Proverb.Recite(new string[] { /*"nail", "shoe"*//*, "horse", "rider", "message", "battle", "kingdom"*/ });
            Console.WriteLine(string.Join("\r\n",s));
        }
    }
    public static class Proverb
    {
        public static string[] Recite(string[] subjects)
        {
            if (subjects.Length is 0) return subjects;
            string s = "";
            for (int i = 0; i < subjects.Length - 1; i++) s += $"For want of a {subjects[i]} the {subjects[i + 1]} was lost.@";
            s += $"And all for the want of a {subjects[0]}.";
            return s.Split('@');
        }
    }
}