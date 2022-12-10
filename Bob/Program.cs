using System.Text;

namespace Bob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Bob.Response(""));
        }
    }
    public static class Bob
    {
        public static string Response(string statement)
        {
            statement =string.Join("", statement.Where(x=>!char.IsControl(x))).TrimEnd();
            var removeNonLetter = string.Join("", statement.Where(c => char.IsLetter(c)));
            var isALLUPPER = removeNonLetter.All(c => char.IsUpper(c)) && removeNonLetter.Length > 0;
            
            switch (statement)
            {
                case string YELLQUESTION when isALLUPPER && statement.Contains('?'): return "Calm down, I know what I'm doing!";
                case string YELL when isALLUPPER: return "Whoa, chill out!";
                case string nothing when statement is "": return "Fine. Be that way!";
                case string question when statement.EndsWith("?"): return "Sure.";


                default: return "Whatever.";
            }
        }
    }
}