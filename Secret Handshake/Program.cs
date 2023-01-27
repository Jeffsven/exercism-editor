namespace Secret_Handshake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",", SecretHandshake.Commands(19)));
        }
    }

    public static class SecretHandshake
    {
        public static string[] Commands(int commandValue)
        {
            bool r = false;
            List<string> handshake = new List<string>();

            while (commandValue > 0)
            {
                if (commandValue >= 16)
                {
                    r = true;
                    commandValue -= 16;
                }
                else if (commandValue >= 8)
                {
                    handshake.Add("jump");
                    commandValue -= 8;
                }
                else if (commandValue >= 4)
                {
                    handshake.Add("close your eyes");
                    commandValue -= 4;
                }
                else if (commandValue >= 2)
                {
                    handshake.Add("double blink");
                    commandValue -= 2;
                }
                else if (commandValue >= 1)
                {
                    handshake.Add("wink");
                    commandValue -= 1;
                }
            }
            return (!r ? handshake.Reverse<string>() : handshake).ToArray();
        }
    }

}