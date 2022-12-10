namespace Phone_Number_Analysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PhoneNumber.Analyze("631-555-1234"));
            Console.WriteLine(PhoneNumber.IsFake(PhoneNumber.Analyze("631-555-1234")));
        }
    }

    public static class PhoneNumber
    {
        public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
        {
            var msg = phoneNumber.Split('-');

            bool IsNewYork = msg[0] is "212";
            bool IsFake = msg[1] is "555";
            string LocalNumber = msg[2];

            return (IsNewYork, IsFake, LocalNumber);
        }

        public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
        {
            return phoneNumberInfo.IsFake;
        }
    }
}