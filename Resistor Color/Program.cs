namespace Resistor_Color
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ResistorColor.ColorCode("black"));
        }
    }



    public static class ResistorColor
    {
        public enum EColorCode
        {
            BLACK = 0,
            BROWN = 1,
            RED = 2,
            ORANGE = 3,
            YELLOW = 4,
            GREEN = 5,
            BLUE = 6,
            VIOLET = 7,
            GREY = 8,
            WHITE = 9,
        }
        public static int ColorCode(string color)
        {
            var clr = (EColorCode)Enum.Parse(typeof(EColorCode), color.ToUpper());
            return (int)clr;
        }

        public static string[] Colors()
        {
            return Enum.GetNames(typeof(EColorCode)).Select(c=>c.ToLower()).ToArray();
        }
    }
}