namespace Log_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LogAnalysis.SubstringBetween("FIND >>> SOMETHING <===< HERE", ">>> ", " <===<"));
        }
    }

    public static class LogAnalysis
    {
        public static string SubstringAfter(this string s, string delimiter)
        {
            var arr = s.Split(delimiter);
            return arr[1];
        }
        public static string SubstringBetween(this string s, string delimiter1, string delimiter2)
        {
            int index1 = s.IndexOf(delimiter1) + delimiter1.Length;
            int index2 = s.IndexOf(delimiter2);
            var svalue = s.Substring(index1, index2 - index1);
            return svalue;
        }
        public static string Message(this string s)
        {
            return s.SubstringAfter(": ");
        }
        public static string LogLevel(this string s)
        {
            return s.SubstringBetween("[", "]");
        }
    }
}