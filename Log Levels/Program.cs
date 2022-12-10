namespace Log_Levels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LogLine.Message("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Message("[WARNING]:  Disk almost full\r\n"));

            Console.WriteLine(LogLine.LogLevel("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.LogLevel("[WARNING]:  Disk almost full\r\n"));

            Console.WriteLine(LogLine.Reformat("[ERROR]: Invalid operation"));
            Console.WriteLine(LogLine.Reformat("[WARNING]:  Disk almost full\r\n"));
        }
    }

    static class LogLine
    {
        public static string Message(string logLine)
        {
            var msg = logLine.Split(':');
            return msg[1].Trim();

        }

        public static string LogLevel(string logLine)
        {
            var msg = logLine.Split(':');
            var s = msg[0].Replace("[", "").Replace("]", "");
            return s.ToLower();
        }

        public static string Reformat(string logLine)
        {
            return $"{Message(logLine)} ({LogLevel(logLine)})";

        }
    }
}