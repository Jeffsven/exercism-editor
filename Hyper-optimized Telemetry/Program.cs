
namespace Hyper_optimized_Telemetry
{
    using System.Linq;
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TelemetryBuffer.FromBuffer(new byte[] { 0xfe, 0xff, 0xff, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 }));
        }
    }

    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            byte[] b = new byte[0];
            bool isSign = false;

            if (reading > uint.MaxValue) { b = BitConverter.GetBytes(reading); isSign = true; }
            else if (reading > int.MaxValue) { b = BitConverter.GetBytes((uint)reading); isSign = false; }
            else if (reading > ushort.MaxValue) { b = BitConverter.GetBytes((int)reading); isSign = true; }
            else if (reading >= 0) { b = BitConverter.GetBytes((ushort)reading); isSign = false; }
            else if (reading >= short.MinValue) { b = BitConverter.GetBytes((short)reading); isSign = true; }
            else if (reading >= int.MinValue) { b = BitConverter.GetBytes((int)reading); isSign = true; }
            else if (reading >= long.MinValue) { b = BitConverter.GetBytes(reading); isSign = true; }

            int prefix = (isSign ? 256 - b.Length : b.Length);

            while (b.Length < 8) b = b.Append<byte>(0).ToArray();

            return new byte[] { (byte)prefix }.Concat(b).ToArray();
        }

        public static long FromBuffer(byte[] buffer)
        {
            var f = BitConverter.ToUInt64(buffer, 1);
            switch (buffer[0])
            {
                case 2:
                case 4:
                case 8: return BitConverter.ToInt64(buffer, 1);
                case 256 - 2: return BitConverter.ToInt16(buffer, 1);
                case 256 - 4: return BitConverter.ToInt32(buffer, 1);
                case 256 - 8: return (long)BitConverter.ToInt64(buffer, 1);
                default: return 0;
            }
        }
    }
}